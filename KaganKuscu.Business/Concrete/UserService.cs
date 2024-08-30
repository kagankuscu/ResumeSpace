using System.Security.Claims;
using AutoMapper;
using KaganKuscu.Business.Abstract;
using KaganKuscu.Model.Dtos.UserDto;
using KaganKuscu.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query;

namespace KaganKuscu.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<UserForGetDto> GetUser(ClaimsPrincipal userClaims)
        {
            return _mapper.Map<UserForGetDto>(await _userManager.GetUserAsync(userClaims));
        }

        public async Task<UserForGetDto> GetUserByUsername(string username)
        {
            return _mapper.Map<UserForGetDto>(await _userManager.FindByNameAsync(username));
        }

        public async Task<UserForGetDto> UpdateUser(UserForUpdateDto user, ClaimsPrincipal userClaims)
        {
            AppUser? real = await _userManager.GetUserAsync(userClaims);
            var result = await _userManager.UpdateAsync(_mapper.Map(user, real)!);
            if (!result.Succeeded)
                return new UserForGetDto();
            return _mapper.Map<UserForGetDto>(real);
        }
    }
}