using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class ViewMoviesModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IMovieModelRepository _movieContext;
        public ViewMoviesModel(ISitemapModelRepository sitemapContext, IMovieModelRepository movieContext)
        {
            _sitemapContext = sitemapContext;
            _movieContext = movieContext;
        }

        public uint PageNumber { get; set; }

        public IEnumerable<MovieModel> AllMovies { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            AllMovies = _movieContext.Movies;

            return Page();
        }
    }
}