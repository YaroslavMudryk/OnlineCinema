using Microsoft.EntityFrameworkCore;
using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFUserRepository : EFRepository<User>, IUserRepository
    {
        public EFUserRepository(CinemaContext db) : base(db) { }

        public async Task<List<User>> SearchUsersAsync(string name, int afterId)
        {
            return await _db.Users
                .AsNoTracking()
                .Take(20)
                .Where(x => x.Name.Contains(name) && x.Id > afterId)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
        }
    }
}