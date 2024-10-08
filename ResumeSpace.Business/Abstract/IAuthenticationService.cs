﻿using ResumeSpace.Model.Dtos;
using ResumeSpace.Model.Dtos.UserDto;
using Microsoft.AspNetCore.Identity;

namespace ResumeSpace.Business.Abstract;

public interface IAuthenticationService
{
    Task<bool> Login(UserForAuthentication userDto);
    Task<bool> Logout();
    Task<IdentityResult> Register(UserForRegistration userDto);
    Task<bool> Recover(UserForForgotPasswordDto forgotPassword);
    Task<IdentityResult> Reset(UserForResetPasswordDto resetPassword);
}
