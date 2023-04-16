using Application.DataTransferObject;
using Domain.Entities.Identity;

namespace Application.Services.Authenticate;

public interface IAuthenticateService
{
    Task EmailVerificationAsync(string email);
    Task<bool> EmailVerificationConfirm(string emailVerificationToken, string userId);
    Task PasswordResetAsync(string email);
    Task<bool> VerifyResetPasswordToken(string resetPasswordToken, string userId);
    Task UpdatePasswordAsync(string userId, string resetToken, string newPassword, string confirmPassword);
    Task Register(RegisterRequestDto registerRequestDto, string userId);
    Task<StorefrontTokenDto> Login(StorefrontLoginDto storefrontLoginDto);
    Task<StorefrontTokenDto> RefreshTokenLoginAsync(string refreshToken);
    StorefrontTokenDto CreateAccessToken();
    string CreateRefreshToken();
    Task UpdateRefreshToken(string refreshToken, AppUser appUser, DateTime accessTokenExpire);
}