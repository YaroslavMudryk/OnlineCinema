using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFUserSessionRepository : EFRepository<UserSession>, IUserSessionRepository
    {
        public EFUserSessionRepository(CinemaContext db) : base(db) { }
    }
}