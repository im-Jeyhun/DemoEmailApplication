using DemoEmailApplication.EmailDM.Models;

namespace DemoEmailApplication.EmailDM.Services
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
