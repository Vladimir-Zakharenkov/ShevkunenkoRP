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
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IMovieModelRepository _movieContext;
        public DetailsMovieModel(ISitemapModelRepository sitemapContext, IMovieModelRepository movieContext)
        {
            _sitemapContext = sitemapContext;
            _movieContext = movieContext;
        }

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public IActionResult OnGet()
        {
            Movie = _movieContext.GetMovieById(Movie.MovieId);

            if (Movie == null)
            {
                RedirectToPage("ViewMovies");
            }

            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }
    }
}