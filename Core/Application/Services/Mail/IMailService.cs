namespace Application.Services.Mail;

public interface IMailService
{
    Task SendMessageAsync(string[] tos, string subject, string body, bool isBodyHtml = true);
}