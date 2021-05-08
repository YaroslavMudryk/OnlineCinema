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
    }
}