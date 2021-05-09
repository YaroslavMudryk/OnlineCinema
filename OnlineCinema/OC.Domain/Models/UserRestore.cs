using System.ComponentModel.DataAnnotations;
namespace OC.Domain.Models
{
    public class UserRestore : BaseModel<int>
    {
        [Required, MinLength(8), MaxLength(8)]
        public string Code { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}