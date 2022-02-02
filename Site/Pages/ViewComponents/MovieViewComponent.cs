using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Movie : ViewComponent
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie(IMovieModelRepository context)
        {
            _movieContext = context;
        }

        public IViewComponentResult Invoke(string movieName)
        {
            MovieModel movie = _movieContext.GetMovie(movieName);

            if (movie == null)
            {
                movie = _movieContext.GetMovie("no-movie");
            }

            return View(movie);
        }
    }
}