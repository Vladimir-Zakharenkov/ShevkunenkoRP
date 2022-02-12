using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class AddMovieModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IMovieModelRepository _movieContext;
        private readonly ICardModelRepository _cardContext;

        public AddMovieModel(ISitemapModelRepository sitemapContext, IMovieModelRepository movieContext, ICardModelRepository cardContext)
        {
            _sitemapContext = sitemapContext;
            _movieContext = movieContext;
            _cardContext = cardContext;
        }

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            if (_cardContext.Cards.FirstOrDefault(x => x.ImageName == Movie.ImageName) == null)
            {
                ModelState.AddModelError("Movie.ImageName", "ViewComponent с таким параметром не существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                _movieContext.AddMovie(Movie);

                return RedirectToPage("/DBCRUD/ViewMovies");
            }
            else
            {
                return Page();
            }
        }
    }
}
