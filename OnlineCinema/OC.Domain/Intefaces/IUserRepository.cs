using OC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OC.Domain.Intefaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<List<User>> SearchUsersAsync(string name, int afterId);
    }
}