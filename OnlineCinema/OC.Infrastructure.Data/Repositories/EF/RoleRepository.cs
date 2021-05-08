using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(CinemaContext db) : base(db) { }
    }
}