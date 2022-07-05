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

        public EmailSenderService(string emailFrom, string smtpHost, int smtpPort)
        {
            _emailFrom = emailFrom;
            _smtpHost = smtpHost;
            _smtpPort = smtpPort;
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
            client.Host = _smtpHost; // "smtp.yandex.ru";
            client.Port = _smtpPort; //587;
            client.EnableSsl = true;

            //Sender's login and password
            client.Credentials = new NetworkCredential(_emailFrom, "#");

            client.Send(mail);
        }
    }
}