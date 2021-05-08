using OC.Application.ViewModels.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Application.Services.Intefaces
{
    public interface IAuthenticationService
    {
        Task<LoginViewModel> LoginByPasswordAsync(LoginModel loginModel);
        Task<LoginViewModel> LoginByQrCodeAsync(LoginModel loginModel);
        Task<RegisterViewModel> RegisterAsync(RegisterModel registerModel);
        Task<ChangePasswordViewModel> ChangePasswordAsync(ChangePasswordModel changePasswordModel);
        Task<RestorePasswordViewModel> RestoreAsync(RestorePasswordModel restorePasswordModel);
        Task<LogoutViewModel> LogoutAsync(LogoutModel logoutModel);
        Task<LogoutViewModel> LogoutOnDeviceAsync(LogoutModel logoutModel);
    }
}