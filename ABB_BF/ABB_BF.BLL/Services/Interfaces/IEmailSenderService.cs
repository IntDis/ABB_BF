using System.Net.Mail;

namespace ABB_BF.BLL.Services.Interfaces
{
    public interface IEmailSenderService
    {
        void SendMessage(string consumer, string subject, Attachment attachment = null);
    }
}