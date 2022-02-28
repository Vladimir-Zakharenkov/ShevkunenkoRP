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

        public void AddMovie(MovieModel movie)
        {
            _siteContext.MovieModels.Add(movie);
            _siteContext.SaveChanges();
        }

        public void DeleteMovie(Guid movieId)
        {
            var movieToDelete = _siteContext.MovieModels.Find(movieId);

            _siteContext.MovieModels.Remove(movieToDelete);
            _siteContext.SaveChanges();
        }

        public void UpdateMovie(MovieModel movieToUpdate)
        {
            var entry = _siteContext.MovieModels.First(e => e.MovieId == movieToUpdate.MovieId);
            _siteContext.Entry(entry).CurrentValues.SetValues(movieToUpdate);
            _siteContext.SaveChanges();
        }

        public MovieModel GetMovie(Guid? movieId)
        {
            MovieModel movie = _siteContext.MovieModels.Find(movieId);

            if (movie == null)
            {
                return null;
            }

            return movie;
        }

        public MovieModel GetMovieByImageName(string imageName)
        {
            MovieModel movie = _siteContext.MovieModels.FirstOrDefault(x => x.ImageName == imageName);

            if (movie == null)
            {
                return null;
            }

            return movie;
        }

        public MovieModel GetMovieByMovieCaption(string movieCaption)
        {
            MovieModel movie = _siteContext.MovieModels.FirstOrDefault(x => x.MovieCaption == movieCaption);

            if (movie == null)
            {
                return null;
            }

            return movie;
        }
    }
}