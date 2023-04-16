namespace Application.Services.Mail;

public interface IMailService
{
    Task SendMailAsync(string to, string subject, string body, bool isBodyHtml = true);
    Task SendEmailVerificationMailAsync(string to, string userId, string emailVerificationToken);
    Task SendPasswordResetMailAsync(string to, string userId, string resetPasswordToken);
}