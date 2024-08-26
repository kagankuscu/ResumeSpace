using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity;

namespace KaganKuscu.Business.Concrete;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AuthenticationService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
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

    public async Task<bool> Register(UserForRegistration userDto)
    {
        AppUser user = new AppUser
            {
                Email = userDto.Email,
                UserName = userDto.Username,
            };
        var result = await _userManager.CreateAsync(user, userDto.Password!);
        if (result.Succeeded)
            await _userManager.AddToRoleAsync(user, "User");

        return result.Succeeded;
    }
}