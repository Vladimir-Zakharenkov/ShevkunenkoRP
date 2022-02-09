using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Movie : ViewComponent
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie(IMovieModelRepository context) => _movieContext = context;

        public IViewComponentResult Invoke(string imageName)
        {
            MovieModel movie = _movieContext.GetMovieByImageName(imageName);

            return View(movie);
        }
    }
}