using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Domain.Models
{
    public class Series : BaseModel<int>
    {
        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }
        [MinLength(5), MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(2500)]
        public string CoverUrl { get; set; }
        [MaxLength(2500)]
        public string VideoUrl { get; set; }
        public long MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}