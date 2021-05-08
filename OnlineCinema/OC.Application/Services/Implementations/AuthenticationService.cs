using OC.Application.Services.Intefaces;
using OC.Application.ViewModels.Authentications;
using OC.Domain.Intefaces;
using System;
using System.Threading.Tasks;
namespace OC.Application.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUserLoginRepository _userLoginRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUserSessionRepository _userSessionRepository;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(
            IRoleRepository roleRepository,
            IUserLoginRepository userLoginRepository,
            IUserRoleRepository userRoleRepository,
            IUserSessionRepository userSessionRepository,
            IUserRepository userRepository)
        {
            _roleRepository = roleRepository;
            _userLoginRepository = userLoginRepository;
            _userRoleRepository = userRoleRepository;
            _userSessionRepository = userSessionRepository;
            _userRepository = userRepository;
        }


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