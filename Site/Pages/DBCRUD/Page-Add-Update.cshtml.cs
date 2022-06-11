using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site.Models;
using Site.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Page_Add_UpdateModel : PageModel
    {
        private readonly SiteContext _siteContext;
        public Page_Add_UpdateModel(SiteContext siteContext)
        {
            _siteContext =siteContext;
        }

        public uint PageNumber { get; set; }

        public SitemapModel SitemapItem { get; set; }

        public IFormFile ImageFile { get; set; }

        public string NameForMovie { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? sitemapModelId)
        {
            PageNumber = 81;

            if (sitemapModelId.HasValue)
            {
                ViewData["Action"] = "Edit";

                SitemapItem =await _siteContext.SitemapModels.Include(i => i.ImageModel).Include(f => f.MovieModel).FirstOrDefaultAsync(p => p.SitemapModelId == sitemapModelId);

                NameForMovie = SitemapItem.MovieModel.MovieCaption;

                return Page();
            }
            else
            {
                ViewData["Action"] = "Add";

                SitemapItem = new();

                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PageNumber = 81;

            if (SitemapItem.SitemapModelId != Guid.Empty)
            {
                ViewData["Action"] = "Edit";
            }
            else
            {
                ViewData["Action"] = "Add";
            }

            if (SitemapItem.SitemapModelId == Guid.Empty)
            {
                if (_siteContext.SitemapModels.FirstOrDefault(x => x.PageNumber == 0) == null)
                {
                    SitemapItem.PageNumber = 0;
                }
                else
                {
                    SitemapItem.PageNumber = _siteContext.SitemapModels.Max(y => y.PageNumber) + 1;
                }

                if (_siteContext.SitemapModels.FirstOrDefault(x => x.Loc == SitemapItem.Loc) != null)
                {
                    ModelState.AddModelError("SitemapItem.Loc", "Такая страница уже существует");

                    return Page();
                }
            }

            // Если файл не выбран
            if (ImageFile == null)
            {
                if (SitemapItem.ImageModelImageId == Guid.Empty)
                {
                    ModelState.AddModelError("ImageFile", "Выберите файл картинки");

                    return Page();
                }
            }
            else
            {
                if (_siteContext.ImageModels.AsEnumerable().FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == ImageFile.FileName) == null)
                {
                    ModelState.AddModelError("ImageFile", "Такого файла картинки нет в базе данных");

                    return Page();
                }
                else
                {
                    SitemapItem.ImageModelImageId = _siteContext.ImageModels.AsEnumerable().FirstOrDefault(x => x.ImageContentUrl.Segments.Last() == ImageFile.FileName).ImageId;
                }
            }

            if (SitemapItem.MoviePage)
            {
                if (_siteContext.MovieModels.AsEnumerable().FirstOrDefault(m => m.MovieCaption == NameForMovie.Trim()) == null)
                {
                    ModelState.AddModelError("NameForMovie", "Фильма с таким названием нет в базе данных");

                    return Page();
                }
                else
                {
                    SitemapItem.MovieModelMovieId = _siteContext.MovieModels.AsEnumerable().FirstOrDefault(m => m.MovieCaption == NameForMovie.Trim()).MovieId;
                }
            }
            else
            {
                SitemapItem.MovieModelMovieId = _siteContext.MovieModels.AsEnumerable().FirstOrDefault(m => m.MovieCaption == "Криминальная звезда").MovieId;
            }

            if (ModelState.IsValid)
            {
                if (SitemapItem.SitemapModelId == Guid.Empty)
                {
                    await _siteContext.SitemapModels.AddAsync(SitemapItem);
                    await _siteContext.SaveChangesAsync();
                }
                else
                {
                    SitemapModel page = await _siteContext.SitemapModels.FindAsync(SitemapItem.SitemapModelId);

                    page.PageNumber = SitemapItem.PageNumber;
                    page.Loc = SitemapItem.Loc;
                    page.Lastmod = SitemapItem.Lastmod;
                    page.Changefreq = SitemapItem.Changefreq;
                    page.Priority = SitemapItem.Priority;
                    page.LeftBackground = SitemapItem.LeftBackground;
                    page.RightBackground = SitemapItem.RightBackground;
                    page.Title = SitemapItem.Title;
                    page.Description = SitemapItem.Description;
                    page.KeyWords = SitemapItem.KeyWords;
                    page.CardText = SitemapItem.CardText;
                    page.MoviePage = SitemapItem.MoviePage;
                    page.ImageModelImageId = SitemapItem.ImageModelImageId;
                    page.MovieModelMovieId = SitemapItem.MovieModelMovieId;

                    await _siteContext.SaveChangesAsync();
                }

                return RedirectToPage("/DBCRUD/Page-List");
            }
            else
            {
                return Page();
            }
        }
    }
}