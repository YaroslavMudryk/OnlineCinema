using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Domain.Models
{
    public class Role : BaseModel<int>
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int Priority { get; set; }
    }
}