using Application.DataTransferObject;
using Domain.Entities.Identity;

namespace Application.Services.Authenticate;

public interface IAuthenticateService
{
    Task EmailVerificationAsync(string email);
    Task<bool> EmailVerificationConfirm(string emailVerificationToken, string userId);
    Task Register(RegisterRequestDto registerRequestDto, string userId);
}