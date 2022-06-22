using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Movie_Add_UpdateModel : PageModel
    {
        private readonly SiteContext _siteContext;
        private readonly IMovieModelRepository _movieContext;

        public Movie_Add_UpdateModel(SiteContext siteContext, IMovieModelRepository movieContext)
        {
            _siteContext = siteContext;
            _movieContext = movieContext;
        }

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public IFormFile ImageFile { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? movieId)
        {
            PageNumber = 93;

            if (movieId.HasValue)
            {
                Movie = await _movieContext.Movies.FirstOrDefaultAsync(p => p.MovieId == movieId);

                if (Movie == null)
                {
                    return RedirectToPage("/DBCRUD/Movie-List");
                }

                ViewData["Action"] = "Edit";

                return Page();
            }
            else
            {
                ViewData["Action"] = "Add";

                Movie = new();

                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PageNumber = 93;

            if (Movie.MovieId == Guid.Empty)
            {
                ViewData["Action"] = "Add";
            }
            else
            {
                ViewData["Action"] = "Edit";
            }

            // Если файл не выбран
            if (ImageFile == null)
            {
                if (Movie.MovieId == Guid.Empty)
                {
                    ModelState.AddModelError("ImageFile", "Выберите файл картинки");

                    return Page();
                }
            }
            else
            {
                if (await _siteContext.ImageModels.AsAsyncEnumerable().FirstOrDefaultAsync(x => x.ImageContentUrl.Segments.Last() == ImageFile.FileName) == null & await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageThumbnailUrl.Segments.Last() == ImageFile.FileName) == null)
                {
                    ModelState.AddModelError("ImageFile", "Такого файла картинки нет в базе данных");

                    return Page();
                }
                else
                {
                    if (await _siteContext.ImageModels.AsAsyncEnumerable().FirstOrDefaultAsync(x => x.ImageThumbnailUrl.Segments.Last() == ImageFile.FileName) != null)
                    {
                        Movie.ImageModelImageId = _siteContext.ImageModels.AsEnumerable().FirstOrDefault(y => y.ImageThumbnailUrl.Segments.Last() == ImageFile.FileName).ImageId;
                    }
                    else
                    {
                        Movie.ImageModelImageId = _siteContext.ImageModels.AsEnumerable().FirstOrDefault(b => b.ImageContentUrl.Segments.Last() == ImageFile.FileName).ImageId;
                    }
                }
            }

            if (Movie.MovieId == Guid.Empty)
            {
                if (await _siteContext.MovieModels.FirstOrDefaultAsync(m => m.MovieCaption == Movie.MovieCaption) != null)
                {
                    ModelState.AddModelError("Movie.Caption", "Фильм с таким названием уже есть в базе данных");

                    return Page();
                }
            }

            if (ModelState.IsValid)
            {
                if (Movie.MovieId == Guid.Empty)
                {
                    await _movieContext.AddMovieAsync(Movie);
                }
                else
                {
                    ViewData["Action"] = "Edit";

                    await _movieContext.UpdateMovieAsync(Movie);
                }

                return RedirectToPage("/DBCRUD/Movie-List");
            }
            else
            {
                return Page();
            }
        }
    }
}