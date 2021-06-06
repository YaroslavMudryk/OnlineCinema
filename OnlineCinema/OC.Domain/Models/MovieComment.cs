using System.ComponentModel.DataAnnotations;
namespace OC.Domain.Models
{
    public class MovieComment : BaseModel<long>
    {
        [Required, MinLength(1), MaxLength(500)]
        public string Text { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}