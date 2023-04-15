using System.Net;
using System.Net.Mail;
using Application.Services.Mail;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services;

public class MailService: IMailService
{
    private readonly IConfiguration _configuration;

    public MailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task SendMessageAsync(string[] tos, string subject, string body, bool isBodyHtml = true)
    {
        MailMessage mail = new();
        foreach (var to in tos)
        {
            mail.To.Add(to);
        }
        mail.Subject = subject;
        mail.IsBodyHtml = isBodyHtml;
        mail.Body = body;
        mail.From = new("devcompanyomo@gmail.com", "CAPELLA", System.Text.Encoding.UTF8);

        SmtpClient smtpClient = new();
        smtpClient.Credentials =
            new NetworkCredential(_configuration["Mail:Username"], _configuration["Mail:Password"]);
        smtpClient.Port = int.Parse(_configuration["Mail:Port"]);
        smtpClient.EnableSsl = true;
        smtpClient.Host = _configuration["Mail:Host"];
        await smtpClient.SendMailAsync(mail);
    }
}