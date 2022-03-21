using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class Movie_Add_UpdateModel : PageModel
    {
        private readonly IMovieModelRepository _movieContext;
        private readonly IImageModelRepository _imageContext;
        public Movie_Add_UpdateModel(IMovieModelRepository movieContext, IImageModelRepository imageContext)
        {
            _movieContext = movieContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public IFormFile ImageFile { get; set; }

        public IActionResult OnGet(Guid? movieId)
        {
            PageNumber = 93;

            if (movieId.HasValue)
            {
                Movie = _movieContext.Movies.First(p => p.MovieId == movieId);

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

        public IActionResult OnPost()
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
                    ModelState.AddModelError("ImageFile", "Выберите файл");

                    return Page();
                }
            }
            else
            {
                if (_imageContext.Images.FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == ImageFile.FileName) == null & _imageContext.Images.FirstOrDefault(x => x.ImageThumbnailUrl.Segments.Last() == ImageFile.FileName) == null)
                {
                    ModelState.AddModelError("ImageFile", "Такого файла нет в базе данных");

                    return Page();
                }
                else
                {
                    if (_imageContext.Images.FirstOrDefault(x => x.ImageThumbnailUrl.Segments.Last() == ImageFile.FileName) != null)
                    {
                        Movie.ImageModelImageId = (_imageContext.Images.FirstOrDefault(y => y.ImageThumbnailUrl.Segments.Last() == ImageFile.FileName).ImageId);
                    }
                    else
                    {
                        Movie.ImageModelImageId = (_imageContext.Images.FirstOrDefault(b => b.ImageContentUrl.Segments.Last() == ImageFile.FileName).ImageId);
                    }
                }
            }

            if (ModelState.IsValid)
            {
                if (Movie.MovieId == Guid.Empty)
                {
                    _movieContext.AddMovie(Movie);
                }
                else
                {
                    _movieContext.UpdateMovie(Movie);
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