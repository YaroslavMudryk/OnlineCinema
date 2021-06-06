using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OC.Domain.Models
{
    public class Movie : BaseModel<long>
    {
        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }
        [MinLength(5), MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime PremiereAt { get; set; }
        public string AvatarFull { get; set; }
        public string AvatarSmall { get; set; }
        public string Cover { get; set; }
        [Required]
        public bool IsAdult { get; set; }
        public string TrailerUrl { get; set; }
        public string VideoUrl { get; set; }
        public List<Series> Series { get; set; }
    }
}