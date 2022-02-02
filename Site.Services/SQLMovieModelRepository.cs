using Microsoft.EntityFrameworkCore;
using Site.Models;
using System.Linq;

namespace Site.Services
{
    public class SQLMovieModelRepository : IMovieModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLMovieModelRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }

        public MovieModel GetMovie(string movieName)
        {
            return _siteContext.MovieModels.Include(p => p.ImageModel).FirstOrDefault(x => x.MovieName == movieName);
        }
    }
}