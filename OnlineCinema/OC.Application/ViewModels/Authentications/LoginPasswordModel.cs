using System.ComponentModel.DataAnnotations;

namespace OC.Application.ViewModels.Authentications
{
    public class LoginPasswordModel
    {
        [Required, MinLength(5), MaxLength(200)]
        public string Login { get; set; }
        [Required, RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$")]
        public string Password { get; set; }
    }
}
