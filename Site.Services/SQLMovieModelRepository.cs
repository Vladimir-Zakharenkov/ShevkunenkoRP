using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Site.Services
{
    public class SQLMovieModelRepository : IMovieModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLMovieModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public IEnumerable<MovieModel> Movies => _siteContext.MovieModels;

        public MovieModel GetMovieById(Guid movieId)
        {
            return _siteContext.MovieModels.FirstOrDefault(x => x.MovieId == movieId);
        }

        public MovieModel GetMovieByImageName(string imageName)
        {
            return _siteContext.MovieModels.FirstOrDefault(x => x.ImageName == imageName);
        }
    }
}