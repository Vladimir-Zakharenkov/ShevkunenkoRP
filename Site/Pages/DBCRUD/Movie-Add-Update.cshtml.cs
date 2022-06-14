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

        public Movie_Add_UpdateModel(SiteContext siteContext) => _siteContext = siteContext;

        public uint PageNumber { get; set; }

        public MovieModel Movie { get; set; }

        public IFormFile ImageFile { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? movieId)
        {
            PageNumber = 93;

            if (movieId.HasValue)
            {
                Movie = await _siteContext.MovieModels.FirstOrDefaultAsync(p => p.MovieId == movieId);

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

            if (Movie.Actor01 == null) Movie.Actor01 = string.Empty;
            if (Movie.Actor02 == null) Movie.Actor02 = string.Empty;
            if (Movie.Actor03 == null) Movie.Actor03 = string.Empty;
            if (Movie.Actor04 == null) Movie.Actor04 = string.Empty;
            if (Movie.Actor05 == null) Movie.Actor05 = string.Empty;
            if (Movie.Actor06 == null) Movie.Actor06 = string.Empty;
            if (Movie.Actor07 == null) Movie.Actor07 = string.Empty;
            if (Movie.Actor08 == null) Movie.Actor08 = string.Empty;
            if (Movie.Actor09 == null) Movie.Actor09 = string.Empty;
            if (Movie.Actor10 == null) Movie.Actor10 = string.Empty;

            if (ModelState.IsValid)
            {
                if (Movie.MovieId == Guid.Empty)
                {
                    await _siteContext.MovieModels.AddAsync(Movie);
                    await _siteContext.SaveChangesAsync();
                }
                else
                {
                    ViewData["Action"] = "Edit";

                    MovieModel movie = await _siteContext.MovieModels.FirstAsync(r => r.MovieId == Movie.MovieId);

                    movie.MovieCaption = Movie.MovieCaption;
                    movie.Duration = Movie.Duration;
                    movie.DatePublished = Movie.DatePublished;
                    movie.DateCreated = Movie.DateCreated;
                    movie.UploadDate = Movie.UploadDate;
                    movie.IsFamilyFriendly = Movie.IsFamilyFriendly;
                    movie.InLanguage = Movie.InLanguage;
                    movie.РroductionCompany = Movie.РroductionCompany;
                    movie.Director = Movie.Director;
                    movie.MusicBy = Movie.MusicBy;
                    movie.Genre = Movie.Genre;
                    movie.Description = Movie.Description;
                    movie.DescriptionForSchemaOrg = Movie.DescriptionForSchemaOrg;
                    movie.Actor01 = Movie.Actor01;
                    movie.Actor02 = Movie.Actor02;
                    movie.Actor03 = Movie.Actor03;
                    movie.Actor04 = Movie.Actor04;
                    movie.Actor05 = Movie.Actor05;
                    movie.Actor06 = Movie.Actor06;
                    movie.Actor07 = Movie.Actor07;
                    movie.Actor08 = Movie.Actor08;
                    movie.Actor09 = Movie.Actor09;
                    movie.Actor10 = Movie.Actor10;
                    movie.ContentUrl = Movie.ContentUrl;
                    movie.CaptionForOnline = Movie.CaptionForOnline;
                    movie.YouTube = Movie.YouTube;
                    movie.VkVideo = Movie.VkVideo;
                    movie.MailRuVideo = Movie.MailRuVideo;
                    movie.OkVideo = Movie.OkVideo;
                    movie.YandexDiskVideo = Movie.YandexDiskVideo;
                    movie.KinoTeatrRu = Movie.KinoTeatrRu;
                    movie.AspPage = Movie.AspPage;
                    movie.ScreenFormat = Movie.ScreenFormat;
                    movie.ImageModelImageId = Movie.ImageModelImageId;



                    await _siteContext.SaveChangesAsync();
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