using DemoEmailApplication.EmailDM.Models;
using DemoEmailApplication.NotifactionDm.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEmailApplication.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {

        }

       public DbSet<Email> Emails { get; set; }

        public DbSet<Notification> Notifactions { get; set; }

    }
}
