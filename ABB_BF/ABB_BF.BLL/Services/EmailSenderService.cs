using ABB_BF.BLL.Services.Interfaces;
using System.Net;
using System.Net.Mail;

namespace ABB_BF.BLL.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private string _emailFrom;
        private readonly string _smtpHost;
        private readonly int _smtpPort;

        public EmailSenderService()
        {
            _emailFrom = "azarovrom9215@yandex.ru";
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
            client.Credentials = new NetworkCredential(_emailFrom, "Azarov9215");

            client.Send(mail);
        }
    }
}