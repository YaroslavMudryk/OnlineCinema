using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public List<UserLogin> UserLogins { get; set; }
        public List<UserSession> UserSessions { get; set; }
    }
}