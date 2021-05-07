using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models
{
    public class BaseCreateModel
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedFromIP { get; set; }
    }

    public class BaseEditModel
    {
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedFromIP { get; set; }
    }

    public class BaseModel : BaseEditModel
    {

    }

    public class BaseModel<TypeId> : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TypeId Id { get; set; }
    }

    public class BaseModelWithoutGeneratingId<TypeId> : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public TypeId Id { get; set; }
    }
}
