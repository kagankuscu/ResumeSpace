using KaganKuscu.Model.Dtos;

namespace KaganKuscu.Business.Abstract;

public interface IAuthenticationService
{
    Task<bool> Login(UserForAuthentication userDto);
    Task<bool> Logout();
    Task<bool> Register(UserForRegistration userDto);
}
