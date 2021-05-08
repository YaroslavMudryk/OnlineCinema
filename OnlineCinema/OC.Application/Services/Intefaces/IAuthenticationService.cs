using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Application.Services.Intefaces
{
    public interface IAuthenticationService
    {
        Task LoginByPasswordAsync();
        Task LoginByQrCodeAsync();
        Task RegisterAsync();
        Task ChangePasswordAsync();
        Task RestoreAsync();
        Task LogoutAsync();
        Task LogoutOnDeviceAsync();
    }
}