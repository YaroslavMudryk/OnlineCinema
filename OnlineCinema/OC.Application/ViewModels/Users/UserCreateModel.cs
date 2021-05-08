using System.ComponentModel.DataAnnotations;

namespace OC.Application.ViewModels.Users
{
    public class UserCreateModel
    {
        [Required, MinLength(5), MaxLength(200)]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required, MinLength(2), MaxLength(150)]
        public string Name { get; set; }
        [MinLength(3), MaxLength(30)]
        public string Username { get; set; }
        [MinLength(5), MaxLength(500)]
        public string Avatar { get; set; }
    }
}
