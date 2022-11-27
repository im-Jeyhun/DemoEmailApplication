using DemoEmailApplication.EmailDM.Models;
using System.ComponentModel.DataAnnotations;

namespace DemoEmailApplication.NotifactionDm.ViewModel
{
    public class AddViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string From { get; set; }
        [Required]

        public string Title { get; set; }
        [Required]

        public string Subject { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public Email Email { get; set; }

        public bool IsBulk { get; set; }


    }
}
