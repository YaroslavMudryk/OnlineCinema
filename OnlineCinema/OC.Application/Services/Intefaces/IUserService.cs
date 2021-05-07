using OC.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Application.Services.Intefaces
{
    public interface IUserService
    {
        Task<Result> GetUserByIdAsync(int id);
        Task<Result> SearchUsersAsync(string name, int afterId = 0);
    }
}