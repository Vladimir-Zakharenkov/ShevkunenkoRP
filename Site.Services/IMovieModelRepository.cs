using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Services
{
    public interface IMovieModelRepository
    {
        public IEnumerable<MovieModel> Movies { get; }

        MovieModel GetMovieByImageName(string imageName);

        MovieModel GetMovieById(Guid imageId);
    }
}