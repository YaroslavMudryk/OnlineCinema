using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class UserRestoreRepository : EFRepository<UserRestore>, IUserRestoreRepository
    {
        public UserRestoreRepository(CinemaContext db) : base(db) { }
    }
}