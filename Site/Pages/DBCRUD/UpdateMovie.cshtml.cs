using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class UpdateMovieModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IMovieModelRepository _movieContext;
        private readonly ICardModelRepository _cardContext;

        public UpdateMovieModel(ISitemapModelRepository sitemapContext, IMovieModelRepository movieContext, ICardModelRepository cardContext)

        {
            _sitemapContext = sitemapContext;
            _movieContext = movieContext;
            _cardContext = cardContext;
        }

        public uint PageNumber { get; set; }

        public MovieModel MovieToUpdate { get; set; }

        public IActionResult OnGet(Guid? movieId)
        {
            if (movieId == null || _movieContext.Movies.FirstOrDefault(x => x.MovieId == movieId) == null)
            {
                return RedirectToPage("ViewMovies");
            }

            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            MovieToUpdate = _movieContext.GetMovie(movieId);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            if (_cardContext.Cards.FirstOrDefault(x => x.ImageName == MovieToUpdate.ImageName) == null)
            {
                ModelState.AddModelError("MovieToUpdate.ImageName", "ViewComponent с таким параметром не существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                _movieContext.UpdateMovie(MovieToUpdate);

                return RedirectToPage("ViewMovies");
            }

            return Page();
        }
    }
}