using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFRoleRepository : EFRepository<Role>, IRoleRepository
    {
        public EFRoleRepository(CinemaContext db) : base(db) { }
    }
}