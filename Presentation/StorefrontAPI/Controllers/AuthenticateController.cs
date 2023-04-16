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
            return Ok();
        }
        
        [HttpPost("/verify-email")]
        public async Task<IActionResult> EmailVerifyConfirm([FromBody] EmailVerificationConfirmDto emailVerificationConfirmDto)
        {
            var result = await _authenticateService.EmailVerificationConfirm(emailVerificationConfirmDto.EmailVerificationToken,
                emailVerificationConfirmDto.UserId);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        
        [HttpPost("/register/{userId}")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto, [FromRoute] string userId)
        {
            await _authenticateService.Register(registerRequestDto, userId);
            return Ok();
        }
    }
}
