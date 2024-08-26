using KaganKuscu.Model.Dtos;
using Microsoft.AspNetCore.Identity;

namespace KaganKuscu.Business.Abstract;

public interface IAuthenticationService
{
    Task<bool> Login(UserForAuthentication userDto);
    Task<bool> Logout();
    Task<IdentityResult> Register(UserForRegistration userDto);
}
