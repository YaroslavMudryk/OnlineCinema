using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFUserLoginRepository : EFRepository<UserLogin>, IUserLoginRepository
    {
        public EFUserLoginRepository(CinemaContext db) : base(db) { }
    }
}