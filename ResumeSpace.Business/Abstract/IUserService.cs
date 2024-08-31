using System.Security.Claims;
using ResumeSpace.Model.Dtos.UserDto;

namespace ResumeSpace.Business.Abstract
{
    public interface IUserService
    {
        Task<UserForGetDto> GetUser(ClaimsPrincipal userClaims);
        Task<UserForGetDto> GetUserByUsername(string username);
        Task<UserForGetDto> UpdateUser(UserForUpdateDto user, ClaimsPrincipal userClaims);
    }
}