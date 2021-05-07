using AutoMapper;
using OC.Application.Results;
using OC.Application.Services.Intefaces;
using OC.Application.ViewModels.Users;
using OC.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<Result> GetAllUsersAsync()
        {
            var usersFromDb = await _userRepository.GetAllAsync();
            if (usersFromDb is null)
                return new Result("Users not found");
            var usersForView = _mapper.Map<List<UserViewModel>>(usersFromDb);
            return new Result(usersForView);
        }

        public async Task<Result> GetUserByIdAsync(int id)
        {
            var userFromDb = await _userRepository.GetFirstAsync(d => d.Id == id);
            if (userFromDb is null)
                return new Result("User by id not found");
            var userForView = _mapper.Map<UserViewModel>(userFromDb);
            return new Result(userForView);
        }

        public async Task<Result> SearchUsersAsync(string name, int afterId = 0)
        {
            var usersFromDb = await _userRepository.SearchUsersAsync(name, afterId);
            if (usersFromDb is null)
                return new Result("Users by name not found");
            var usersForView = _mapper.Map<List<UserViewModel>>(usersFromDb);
            return new Result(usersForView);
        }
    }
}