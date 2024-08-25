using System.Security.Claims;
using KaganKuscu.Model.Dtos.UserDto;

namespace KaganKuscu.Business.Abstract
{
    public interface IUserService
    {
        Task<UserForGetDto> GetUser(ClaimsPrincipal userClaims);
        Task<UserForGetDto> UpdateUser(UserForUpdateDto user, ClaimsPrincipal userClaims);
    }
}