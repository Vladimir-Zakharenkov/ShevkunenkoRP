using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class DetailsMovieModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        public DetailsMovieModel(IMovieModelRepository movieContext)
        {
            _movieContext = movieContext;
        }

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 17;

            Movie = _movieContext.GetMovie(Movie.MovieId);

            if (Movie == null)
            {
                return RedirectToPage("ViewMovies");
            }

            return Page();
        }
    }
}