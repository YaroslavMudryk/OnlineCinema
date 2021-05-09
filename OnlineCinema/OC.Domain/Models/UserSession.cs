using System;
using System.ComponentModel.DataAnnotations;

namespace OC.Domain.Models
{
    public class UserSession : BaseModel<Guid>
    {
        [MaxLength(40)]
        public string AppId { get; set; }
        [MaxLength(50)]
        public string AppName { get; set; }
        [MaxLength(50)]
        public string Device { get; set; }
        [MaxLength(50)]
        public string TypeDevice { get; set; }
        [MaxLength(50)]
        public string ModelDevice { get; set; }
        [MaxLength(50)]
        public string OS { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}