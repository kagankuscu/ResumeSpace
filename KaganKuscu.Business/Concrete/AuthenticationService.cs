using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.EmailService;
using KaganKuscu.EmailService.Concrete;
using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Dtos.UserDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;

namespace KaganKuscu.Business.Concrete;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IMapper _mapper;
    private readonly IEmailSender _emailSender;

    public AuthenticationService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper, IEmailSender emailSender)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
        _emailSender = emailSender;
    }

    public async Task<bool> Login(UserForAuthentication userDto)
    {
        var result = await _signInManager.PasswordSignInAsync(userDto.Username!, userDto.Password!, userDto.RememberMe, false);

        return result.Succeeded;
    }

    public async Task<bool> Logout()
    {
        await _signInManager.SignOutAsync();
        return true;
    }

    public async Task<bool> Recover(UserForForgotPasswordDto forgotPassword)
    {
        AppUser? user = await _userManager.FindByNameAsync(forgotPassword.Username);

        if (user is null)
            return false;

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var param = new Dictionary<string, string>()
        {
            { "token", token },
            { "username", forgotPassword.Username }
        };

        var callback = QueryHelpers.AddQueryString(forgotPassword.ClientUri, param);
        var message = new Message(new string[] { user.Email! }, "Reset password token", callback);
        await _emailSender.SendEmailAsync(message);
        return true;
    }

    public async Task<IdentityResult> Register(UserForRegistration userDto)
    {
        AppUser user = _mapper.Map<AppUser>(userDto);
        var result = await _userManager.CreateAsync(user, userDto.Password!);
        if (!result.Succeeded)
            return result;

        await _userManager.AddToRoleAsync(user, "User");

        return result;
    }

    public async Task<IdentityResult> Reset(UserForResetPasswordDto resetPassword)
    {
        AppUser? user = await _userManager.FindByNameAsync(resetPassword.Username!);

        if (user is null)
            return new IdentityResult();

        var result = await _userManager.ResetPasswordAsync(user, resetPassword.Token!, resetPassword.Password!);

        return result;
    }
}