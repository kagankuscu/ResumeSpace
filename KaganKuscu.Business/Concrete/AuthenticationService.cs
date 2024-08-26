using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity;

namespace KaganKuscu.Business.Concrete;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IMapper _mapper;

    public AuthenticationService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
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

    public async Task<IdentityResult> Register(UserForRegistration userDto)
    {
        AppUser user = _mapper.Map<AppUser>(userDto);
        var result = await _userManager.CreateAsync(user, userDto.Password!);
        if (!result.Succeeded)
            return result;

        await _userManager.AddToRoleAsync(user, "User");

        return result;
    }
}