using OC.Application.Results;
using OC.Application.Results.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Application.Services.Intefaces
{
    public interface IUserService
    {
        Task<UserListResult> GetAllUsersAsync();
        Task<UserResult> GetUserByIdAsync(int id);
        Task<UserListResult> SearchUsersAsync(string name, int afterId = 0);
    }
}