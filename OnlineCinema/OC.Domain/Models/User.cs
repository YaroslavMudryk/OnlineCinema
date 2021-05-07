using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Domain.Models
{
    public class User : BaseModel<int>
    {
        [Required, MinLength(2), MaxLength(150)]
        public string Name { get; set; }
        [MinLength(3), MaxLength(30)]
        public string Username { get; set; }
        [MinLength(5), MaxLength(500)]
        public string Avatar { get; set; }
    }
}