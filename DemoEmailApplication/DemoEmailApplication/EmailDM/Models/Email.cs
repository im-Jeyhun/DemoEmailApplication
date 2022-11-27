using DemoEmailApplication.NotifactionDm.Models;

namespace DemoEmailApplication.EmailDM.Models
{
    public class Email
    {
        public int Id { get; set; }

        public string To { get; set; }

        
        public List<Notification> Notifications { get; set; }

    }
}
