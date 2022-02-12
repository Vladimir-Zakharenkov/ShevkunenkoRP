using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Services
{
    public interface IMovieModelRepository
    {
        public IEnumerable<MovieModel> Movies { get; }

        MovieModel GetMovieByImageName(string imageName);

        MovieModel GetMovie(Guid? movieId);

        void AddMovie(MovieModel movie);

        void UpdateMovie(MovieModel image);

        void DeleteMovie(Guid movieId);
    }
}