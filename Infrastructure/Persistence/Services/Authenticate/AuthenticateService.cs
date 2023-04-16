using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Application.DataTransferObject;
using Application.Services.Authenticate;
using Application.Services.Mail;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Persistence.Services.Authenticate;

public class AuthenticateService: IAuthenticateService
{
    private UserManager<AppUser> _userManager;
    private IMailService _mailService;
    private IConfiguration _configuration;

    public AuthenticateService(UserManager<AppUser> userManager, IMailService mailService, IConfiguration configuration)
    {
        _userManager = userManager;
        _mailService = mailService;
        _configuration = configuration;
    }
    
    public async Task EmailVerificationAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            user = new AppUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = email,
                Email = email
            };
            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                throw new ApplicationException("Kullanıcı kayıt olurken bir hata meydana geldi.");
            }  
        }else if (user.EmailConfirmed)
        {
            throw new ApplicationException("Bu e-posta kayıtlıdır.");
        }
        var emailVerificationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        byte[] tokenBytes = Encoding.UTF8.GetBytes(emailVerificationToken);
        emailVerificationToken = WebEncoders.Base64UrlEncode(tokenBytes);
        await _mailService.SendEmailVerificationMailAsync(user.Email,user.Id,emailVerificationToken);

    }
    public async Task<bool> EmailVerificationConfirm(string emailVerificationToken, string userId)
    {
        var appuser = await _userManager.FindByIdAsync(userId);
        if (appuser != null)
        {
            byte[] tokenBytes = WebEncoders.Base64UrlDecode(emailVerificationToken);
            var token = Encoding.UTF8.GetString(tokenBytes);

            return await _userManager.VerifyUserTokenAsync(appuser, _userManager.Options.Tokens.EmailConfirmationTokenProvider,
                "EmailConfirmation", token);     
        }
        return false;
    }
    
    public async Task Register(RegisterRequestDto registerRequestDto,string userId)
    {
        var appuser = await _userManager.FindByIdAsync(userId);
        if (appuser != null)
        {
            var passwordResult = await _userManager.AddPasswordAsync(appuser,registerRequestDto.Password);
            if (!passwordResult.Succeeded)
            {
                throw new ApplicationException("Şifre oluşturulurken bir hata meydana geldi.");
            }
            appuser.FirstName = registerRequestDto.FirstName;
            appuser.LastName = registerRequestDto.LastName;
            appuser.EmailConfirmed = true;
            var userResult = await _userManager.UpdateAsync(appuser);
            if (!userResult.Succeeded)
            {
                throw new ApplicationException("Kullanıcı oluşturulurken bir hata meydana geldi.");
            }
        }
    }
    public async Task<StorefrontTokenDto> Login(StorefrontLoginDto storefrontLoginDto)
    {
       var user = await _userManager.FindByEmailAsync(storefrontLoginDto.Email);
       if (user == null)
       {
           throw new ApplicationException("E-Posta veya şifre hatalıdır.");
       }
       var result = await _userManager.CheckPasswordAsync(user, storefrontLoginDto.Password);
       if (result)
       {
           StorefrontTokenDto storefrontTokenDto = CreateAccessToken();
           return storefrontTokenDto;
       }
       else
       {
           throw new ApplicationException("E-Posta veya şifre hatalıdır.");
       }
    }

    public StorefrontTokenDto CreateAccessToken()
    {
        StorefrontTokenDto storefrontTokenDto = new StorefrontTokenDto();
        SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));
        SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);
        JwtSecurityToken securityToken = new(
            audience: _configuration["Token:Auidience"],
            issuer: _configuration["Token:Issuer"],
            expires: DateTime.UtcNow.AddDays(7),
            signingCredentials: signingCredentials
        );
        JwtSecurityTokenHandler tokenHandler = new();
        storefrontTokenDto.AccessToken = tokenHandler.WriteToken(securityToken);
        return storefrontTokenDto;
    }
}