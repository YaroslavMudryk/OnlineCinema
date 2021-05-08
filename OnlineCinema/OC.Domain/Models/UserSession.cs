using System;
namespace OC.Domain.Models
{
    public class UserSession : BaseModel<Guid>
    {
        public string AppId { get; set; }
        public string AppName { get; set; }
        public string Device { get; set; }
        public string TypeDevice { get; set; }
        public string ModelDevice { get; set; }
        public string OS { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}