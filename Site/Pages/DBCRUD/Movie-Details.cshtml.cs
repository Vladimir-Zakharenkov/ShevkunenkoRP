using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Movie_DetailsModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        public Movie_DetailsModel(IMovieModelRepository movieContext) => _movieContext = movieContext;

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public void OnGet()
        {
            PageNumber = 92;

            Movie = _movieContext.GetMovie(Movie.MovieId);

            if (Movie == null)
            {
                RedirectToPage("/DBCRUD/Movie-List");
            }
        }
    }
}