using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Application.ViewModels.Authentications
{
    public class RestorePasswordCodeModel
    {
        [Required, MinLength(5), MaxLength(200)]
        public string Login { get; set; }
    }
}