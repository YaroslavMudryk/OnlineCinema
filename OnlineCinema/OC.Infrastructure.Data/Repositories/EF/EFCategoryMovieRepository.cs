using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFCategoryMovieRepository : EFRepository<CategoryMovie>, ICategoryMovieRepository
    {
        public EFCategoryMovieRepository(CinemaContext db) : base(db) { }
    }
}