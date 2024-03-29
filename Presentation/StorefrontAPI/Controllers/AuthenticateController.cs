using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DataTransferObject;
using Application.Services.Authenticate;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StorefrontAPI.Utilities.ResponseData;

namespace StorefrontAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private IAuthenticateService _authenticateService;

        public AuthenticateController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        
        [HttpPost("/createregisterrequest")]
        public async Task<IActionResult> EmailVerification([FromBody] EmailVerificationDto emailVerificationDto)
        {
            await _authenticateService.EmailVerificationAsync(emailVerificationDto.Email);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);
        }
        
        [HttpPost("/verify-email")]
        public async Task<IActionResult> EmailVerifyConfirm([FromBody] EmailVerificationConfirmDto emailVerificationConfirmDto)
        {
            var result = await _authenticateService.EmailVerificationConfirm(emailVerificationConfirmDto.EmailVerificationToken,
                emailVerificationConfirmDto.UserId);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS,
                Data = result
            };
            return Ok(response);
        }
        
        [HttpPost("/password-reset")]
        public async Task<IActionResult> PasswordReset([FromBody] ResetPasswordDto resetPasswordDto)
        {
            await _authenticateService.PasswordResetAsync(resetPasswordDto.Email);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);
        }
        
        [HttpPost("/verify-reset-password")]
        public async Task<IActionResult> VerifyResetPasswordToken([FromBody] VerifyResetPasswordDto verifyResetPassword)
        {
            var result = await _authenticateService.VerifyResetPasswordToken(verifyResetPassword.ResetPasswordToken,
                verifyResetPassword.UserId);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS,
                Data = result
            };
            return Ok(response);
        }
        
        [HttpPost("/update-password")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordDto updatePasswordDto)
        {
            await _authenticateService.UpdatePasswordAsync(updatePasswordDto.UserId, updatePasswordDto.ResetPasswordToken, updatePasswordDto.Password, updatePasswordDto.PasswordConfirm);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS,
            };
            return Ok(response);
        }
        
        [HttpPost("/register/{userId}")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto, [FromRoute] string userId)
        {
            await _authenticateService.Register(registerRequestDto, userId);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS,
            };
            return Ok(response);
        }
        
        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] StorefrontLoginDto storefrontLoginDto)
        {
            var storefrontTokenDto = await _authenticateService.Login(storefrontLoginDto);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS,
                Data = storefrontTokenDto
            };
            return Ok(response);
        }
        
        [HttpPost("/refresh-token-login")]
        public async Task<IActionResult> RefreshTokenLogin([FromBody] RefreshTokenDto refreshTokenDto)
        {
            var storefrontTokenDto = await _authenticateService.RefreshTokenLoginAsync(refreshTokenDto.RefreshToken);
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS,
                Data = storefrontTokenDto
            };
            return Ok(response);
        }
        
        
    }
}
