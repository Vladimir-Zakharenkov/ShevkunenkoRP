using System.Collections.Generic;
using System.Threading.Tasks;
using Site.Models;
using System;

namespace Site.Services
{
    public interface IMovieModelRepository
    {
        public IAsyncEnumerable<MovieModel> Movies { get; }

        Task<MovieModel> GetMovieByMovieCaptionAsync(string moviCaption);

        Task<MovieModel> GetMovieAsync(Guid? movieId);

        Task AddMovieAsync(MovieModel movie);

        Task UpdateMovieAsync(MovieModel image);

        Task DeleteMovieAsync(Guid movieId);
    }
}