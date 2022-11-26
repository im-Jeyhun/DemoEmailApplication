using DemoEmailApplication.DataBase;
using Microsoft.EntityFrameworkCore;

namespace DemoEmailApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services
                .AddDbContext<DataContext>(o =>
                {
                    o.UseSqlServer(builder.Configuration.GetConnectionString("CeyhunPc"));
                })
                .AddMvc();



            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}");

            app.Run();
        }
    }
}