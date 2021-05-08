using System.ComponentModel.DataAnnotations;

namespace OC.Application.ViewModels.Authentications
{
    public class RestorePasswordModel
    {
        [Required, MinLength(5), MaxLength(200)]
        public string Login { get; set; }
        [Required, RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$")]
        public string NewPassword { get; set; }
        [Required, Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
        [Required, MinLength(8), MaxLength(8)]
        public string Code { get; set; }
    }
}