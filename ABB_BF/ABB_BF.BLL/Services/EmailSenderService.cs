using ABB_BF.BLL.Services.Interfaces;
using System.Net;
using System.Net.Mail;

namespace ABB_BF.BLL.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly string _smtpHost;
        private readonly int _smtpPort;

        private static readonly string _emailFromEnvVarName = "EMAIL_FROM";
        private readonly string _emailFrom = Environment.GetEnvironmentVariable(_emailFromEnvVarName);

        private static readonly string _emailFromPasswordEnvVarName = "EMAIL_FROM_PASSWORD";
        private readonly string _emailFromPassword = Environment.GetEnvironmentVariable(_emailFromPasswordEnvVarName);

        public EmailSenderService()
        {
            _smtpHost = "smtp.yandex.ru";
            _smtpPort = 587;
        }

        public void SendMessage(string consumer,
            string subject,
            Attachment attachment = null)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(_emailFrom);
            mail.To.Add(new MailAddress(consumer));
            mail.Subject = subject;

            if (attachment is not null)
            {
                mail.Attachments.Add(attachment);
            }

            SmtpClient client = new SmtpClient();
            client.Host = _smtpHost;
            client.Port = _smtpPort;
            client.EnableSsl = true;

            //Sender's login and password
            client.Credentials = new NetworkCredential(_emailFrom, _emailFromPassword);

            client.Send(mail);
        }
    }
}