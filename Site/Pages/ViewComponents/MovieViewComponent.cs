using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Movie : ViewComponent
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie(IMovieModelRepository movieContext) => _movieContext = movieContext;

        public IViewComponentResult Invoke(string movieCaption)
        {
            MovieModel movie = _movieContext.GetMovieByMovieCaption(movieCaption);

            return View(movie);
        }
    }
}