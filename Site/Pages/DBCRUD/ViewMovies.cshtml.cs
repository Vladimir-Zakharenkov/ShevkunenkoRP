using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class ViewMoviesModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        private readonly ISitemapModelRepository _sitemapContext;
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

            AllMovies = _movieContext.Movies.ToArray(); ;

            return Page();
        }
    }
}