using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Application.DataTransferObject;
using Application.Helpers;
using Application.Services.Authenticate;
using Application.Services.Mail;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
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
        emailVerificationToken = emailVerificationToken.UrlEncode();
        await _mailService.SendEmailVerificationMailAsync(user.Email,user.Id,emailVerificationToken);

    }
    public async Task<bool> EmailVerificationConfirm(string emailVerificationToken, string userId)
    {
        var appuser = await _userManager.FindByIdAsync(userId);
        if (appuser != null)
        {
            emailVerificationToken = emailVerificationToken.UrlDecode();
            return await _userManager.VerifyUserTokenAsync(appuser, _userManager.Options.Tokens.EmailConfirmationTokenProvider,
                "EmailConfirmation", emailVerificationToken);     
        }
        return false;
    }

    public async Task PasswordResetAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            resetToken = resetToken.UrlEncode();
            await _mailService.SendPasswordResetMailAsync(user.Email,user.Id,resetToken);
        }
    }

    public async Task<bool> VerifyResetPasswordToken(string resetPasswordToken, string userId)
    {
        var appuser = await _userManager.FindByIdAsync(userId);
        if (appuser != null)
        {
            resetPasswordToken = resetPasswordToken.UrlDecode();
            return await _userManager.VerifyUserTokenAsync(appuser, _userManager.Options.Tokens.PasswordResetTokenProvider,
                "ResetPassword", resetPasswordToken);     
        }
        return false;
    }

    public async Task UpdatePasswordAsync(string userId, string resetToken, string newPassword, string confirmPassword)
    {
        if (!newPassword.Equals(confirmPassword))
        {
            throw new ApplicationException("Girilen şifreler eşleşmemektedir.");
        }
        var appuser = await _userManager.FindByIdAsync(userId);
        if (appuser != null)
        {
            resetToken = resetToken.UrlDecode();
            var result = await _userManager.ResetPasswordAsync(appuser, resetToken, newPassword);
            if (result.Succeeded)
            {
                await _userManager.UpdateSecurityStampAsync(appuser);
            }
            else
            {
                throw new ApplicationException("Şifre değiştirilirken bir sorun oluştu");
            }
        }
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
           JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
           if (handler.CanReadToken(storefrontTokenDto.AccessToken))
           {
               JwtSecurityToken token = handler.ReadJwtToken(storefrontTokenDto.AccessToken);
               DateTime expiration = token.ValidTo;
               await UpdateRefreshToken(storefrontTokenDto.RefreshToken, user, expiration);
           }
           
           return storefrontTokenDto;
       }
       else
       {
           throw new ApplicationException("E-Posta veya şifre hatalıdır.");
       }
    }

    public async Task<StorefrontTokenDto> RefreshTokenLoginAsync(string refreshToken)
    {
        AppUser? appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);
        if (appUser != null && appUser?.RefreshTokenEndTime > DateTime.UtcNow)
        {
            StorefrontTokenDto storefrontTokenDto = CreateAccessToken();
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            if (handler.CanReadToken(storefrontTokenDto.AccessToken))
            {
                JwtSecurityToken token = handler.ReadJwtToken(storefrontTokenDto.AccessToken);
                DateTime expiration = token.ValidTo;
                await UpdateRefreshToken(storefrontTokenDto.RefreshToken, appUser, expiration);
            }
           
            return storefrontTokenDto;
        } else
        {
            throw new ApplicationException("Kullanıcı bulunamadı");   
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
            notBefore: DateTime.Now,
            signingCredentials: signingCredentials
        );
        JwtSecurityTokenHandler tokenHandler = new();
        storefrontTokenDto.AccessToken = tokenHandler.WriteToken(securityToken);
        storefrontTokenDto.RefreshToken = CreateRefreshToken();
        return storefrontTokenDto;
    }

    public string CreateRefreshToken()
    {
        byte[] number = new byte[32];
        using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
        randomNumberGenerator.GetBytes(number);
        return Convert.ToBase64String(number);
    }

    public async Task UpdateRefreshToken(string refreshToken, AppUser appUser,DateTime accessTokenExpire)
    {
        if (appUser != null)
        {
            appUser.RefreshToken = refreshToken;
            appUser.RefreshTokenEndTime = accessTokenExpire.AddSeconds(1000);
            await _userManager.UpdateAsync(appUser);
        }
        else
        {
            throw new ApplicationException("Kullanıcı bulunamadı");   
        }
    }
}