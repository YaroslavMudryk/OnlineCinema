using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFMovieRepository : EFRepository<Movie>, IMovieRepository
    {
        public EFMovieRepository(CinemaContext db) : base(db) { }
    }
}