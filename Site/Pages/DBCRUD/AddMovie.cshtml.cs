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
        private readonly IMovieModelRepository _movieContext;
        private readonly IImageModelRepository _imageContext;
        public AddMovieModel(IMovieModelRepository movieContext, IImageModelRepository imageContext)
        {
            _movieContext = movieContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public void OnGet()
        {
            PageNumber = 21;
        }

        public IActionResult OnPost()
        {
            PageNumber = 21;

            if (_imageContext.Images.FirstOrDefault(x => x.ImageName == Movie.ImageName) == null)
            {
                ModelState.AddModelError("Movie.ImageName", "ViewComponent с таким именем не существует");

                return Page();
            }

            if (_movieContext.Movies.FirstOrDefault(x => x.MovieCaption == Movie.MovieCaption) != null)
            {
                ModelState.AddModelError("Movie.MovieCaption", "Фильм с таким названием уже существует");

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
