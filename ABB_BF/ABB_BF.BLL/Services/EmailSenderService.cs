using System.Net;
using System.Net.Mail;

namespace ABB_BF.BLL.Services
{
    public class EmailSenderService
    {
        private string _emailFrom = "azarovrom9215@yandex.ru";

        public void SendMessage(string consumer,
            string subject,
            string text,
            Attachment attachment = null)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(_emailFrom);
            mail.To.Add(new MailAddress(consumer));
            mail.Subject = subject;
            mail.Body = text;

            if (attachment is not null)
            {
                mail.Attachments.Add(attachment);
            }

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.yandex.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("#", "#"); //Sender's login and password
            client.Send(mail);
        }
    }
}