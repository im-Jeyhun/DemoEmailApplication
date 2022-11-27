using DemoEmailApplication.EmailDM.Models;

namespace DemoEmailApplication.NotifactionDm.Models
{
    public class Notification
    {
        //public Notification(int id, string from, string title, string subject, int emailId, Email email)
        //{
        //    Id = id;
        //    From = from;
        //    Title = title;
        //    Subject = subject;
        //    EmailId = emailId;
        //    Email = email;
        //}

        public int Id { get; set; }
        public string From { get; set; }
        public string Title { get; set; }

        public string Subject { get; set; }
        public int EmailId { get; set; }
        public Email Email { get; set; }

    }
}
