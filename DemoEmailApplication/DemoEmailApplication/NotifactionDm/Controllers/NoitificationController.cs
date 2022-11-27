using DemoEmailApplication.DataBase;
using DemoEmailApplication.EmailDM.Models;
using DemoEmailApplication.EmailDM.Services;
using DemoEmailApplication.NotifactionDm.Models;
using DemoEmailApplication.NotifactionDm.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DemoEmailApplication.NotifactionDm.Controllers
{
    public class NoitificationController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IEmailSender _emailSender;
        private readonly EmailConfiguration _configuration;

        public NoitificationController(DataContext dataContext, IEmailSender emailSender, EmailConfiguration emailConfiguration)
        {
            _dataContext = dataContext;
            _emailSender = emailSender;
            _configuration = emailConfiguration;

        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var model = _dataContext.Notifactions.Select(n => new ListItemViewModel(n.From, $"{n.Email.To}", n.Title)).ToList();
            return View("~/NotifactionDm/Views/Index.cshtml", model);
        }




        public IActionResult Send()
        {
            return View("~/NotifactionDm/Views/Send.cshtml");
        }
        [HttpPost]
        public IActionResult Send(AddViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("~/NotifactionDm/Views/Send.cshtml");

            //}

            var notfication = new Notification
            {
                From = _configuration.From,
                Title = model.Title,
                Subject = model.Subject,
                Email = model.Email,



            };
            _dataContext.Notifactions.Add(notfication);

            _dataContext.Emails.Add(notfication.Email);

            var emails = model.Email.To.Trim().Split(',');
            List<string> targetEmail = new List<string>();

            if (model.IsBulk == true)
            {
                foreach (var email in emails)
                {
                    targetEmail.Add(email);
                }
            }
            else
            {
                if (emails.Length == 1)
                {
                    targetEmail.Add(model.Email.To);
                }
                RedirectToAction(nameof(Send));
            }


            var message = new Message(targetEmail, model.Title, model.Subject);

            _emailSender.SendEmail(message);
            _dataContext.SaveChanges();


            return RedirectToAction(nameof(Index));
        }
    }
}
