using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class DeleteMovieModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IMovieModelRepository _movieContext;

        public DeleteMovieModel(ISitemapModelRepository sitemapContext, IMovieModelRepository movieContext)
        {
            _sitemapContext = sitemapContext;
            _movieContext = movieContext;
        }
        public uint PageNumber { get; set; }

        public MovieModel Movie{ get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 20;

            Movie = _movieContext.GetMovie(Movie.MovieId);

            if (Movie == null)
            {
                return RedirectToPage("ViewMovies");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = 20;

            _movieContext.DeleteMovie(Movie.MovieId);

            return RedirectToPage("ViewMovies");
        }
    }
}
