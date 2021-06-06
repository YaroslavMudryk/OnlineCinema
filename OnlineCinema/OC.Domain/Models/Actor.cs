using System.ComponentModel.DataAnnotations;
namespace OC.Domain.Models
{
    public class Actor : BaseModel<int>
    {
        [Required, MinLength(2), MaxLength(250)]
        public string Name { get; set; }
        [MinLength(2), MaxLength(250)]
        public string NativeName { get; set; }
        public string Photo { get; set; }
    }
}