using e_Tickets.Data.Base;
using e_Tickets.Models;

namespace e_Tickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
