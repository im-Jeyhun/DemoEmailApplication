using DemoEmailApplication.DataBase;
using DemoEmailApplication.EmailDM.Services;
using Microsoft.EntityFrameworkCore;

namespace DemoEmailApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var emailconfig = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            builder.Services.AddControllers();

            builder.Services
                
                .AddSingleton(emailconfig)
                .AddScoped<IEmailSender, EmailSender>()
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