using OC.Application.Services.Intefaces;
using OC.Application.ViewModels.Authentications;
using System;
using System.Threading.Tasks;
namespace OC.Application.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<ChangePasswordViewModel> ChangePasswordAsync(ChangePasswordModel changePasswordModel)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginViewModel> LoginByPasswordAsync(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginViewModel> LoginByQrCodeAsync(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public async Task<LogoutViewModel> LogoutAsync(LogoutModel logoutModel)
        {
            throw new NotImplementedException();
        }

        public async Task<LogoutViewModel> LogoutOnDeviceAsync(LogoutModel logoutModel)
        {
            throw new NotImplementedException();
        }

        public async Task<RegisterViewModel> RegisterAsync(RegisterModel registerModel)
        {
            throw new NotImplementedException();
        }

        public async Task<RestorePasswordViewModel> RestoreAsync(RestorePasswordModel restorePasswordModel)
        {
            throw new NotImplementedException();
        }
    }
}