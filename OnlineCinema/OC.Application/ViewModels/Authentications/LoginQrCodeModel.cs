using System.ComponentModel.DataAnnotations;

namespace OC.Application.ViewModels.Authentications
{
    public class LoginQrCodeModel
    {
        [Required]
        public string QRCode { get; set; }
    }
}