using Microsoft.EntityFrameworkCore;

namespace DemoEmailApplication.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {

        }

        
    }
}
