using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFUserRoleRepository : EFRepository<UserRole>, IUserRoleRepository
    {
        public EFUserRoleRepository(CinemaContext db) : base(db) { }
    }
}