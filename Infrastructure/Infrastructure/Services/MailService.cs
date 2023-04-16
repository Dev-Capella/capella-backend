using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
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
    public async Task SendMailAsync(string to, string subject, string body, bool isBodyHtml = true)
    {
        MailMessage mail = new();
        mail.To.Add(to);
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

    public async Task SendEmailVerificationMailAsync(string to, string userId, string emailVerificationToken)
    {
        StringBuilder mail = new();
        mail.Append("<b>E-posta adresinizi doğrulayın</b><br>" +
                    "Bu e-posta adresinizin aktif ve size ait olduğunu doğrulamak için lütfen aşağıdaki linke tıklayınız<br>" +
                    "<a target=\"_blank\" href=\"");
        mail.Append(HttpUtility.HtmlEncode(_configuration["ReactClientURL"]));
        mail.Append(HttpUtility.HtmlEncode(userId));
        mail.Append("/");
        mail.Append(HttpUtility.HtmlEncode(emailVerificationToken));
        mail.Append("\">Doğrula</a>");

        await SendMailAsync(to, "E-posta adresinizi doğrulayın", mail.ToString());
    }
}