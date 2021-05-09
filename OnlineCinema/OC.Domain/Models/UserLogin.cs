using System.ComponentModel.DataAnnotations;

namespace OC.Domain.Models
{
    public class UserLogin : BaseModel<long>
    {
        [Required, MinLength(5), MaxLength(200)]
        public string Login { get; set; }
        [Required, MaxLength(2500)]
        public string PasswordHash { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}