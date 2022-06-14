using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Movie : ViewComponent
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie(IMovieModelRepository movieContext) => _movieContext = movieContext;

        public async Task<IViewComponentResult> InvokeAsync(string movieCaption)
        {
            MovieModel movie = await _movieContext.GetMovieByMovieCaptionAsync(movieCaption);

            return View(movie);
        }
    }
}