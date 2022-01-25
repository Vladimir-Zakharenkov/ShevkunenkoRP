using Site.Models;

namespace Site.Services
{
    public interface IMovieModelRepository
    {
        MovieModel GetMovie(string movieName);
    }
}