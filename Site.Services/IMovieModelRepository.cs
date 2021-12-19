using System.Collections.Generic;
using Site.Models;

namespace Site.Services
{
    public interface IMovieModelRepository
    {
        IEnumerable<MovieModel> GettAllMovies();
    }
}
