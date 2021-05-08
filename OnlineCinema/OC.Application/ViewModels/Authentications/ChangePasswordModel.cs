using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Application.ViewModels.Authentications
{
    public class ChangePasswordModel
    {
        [Required]
        public string OldPassword { get; set; }
        [Required, RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$")]
        public string NewPassword { get; set; }
        [Required, Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }
}
