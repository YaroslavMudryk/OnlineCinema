using System.ComponentModel.DataAnnotations;
namespace OC.Domain.Models
{
    public class Category : BaseModel<int>
    {
        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }
    }
}