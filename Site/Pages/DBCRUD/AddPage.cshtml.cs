using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [BindProperties(SupportsGet = true)]
    public class AddPageModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IImageModelRepository _imageContext;

        public AddPageModel(ISitemapModelRepository sitemapContext, IImageModelRepository imageContext)
        {
            _sitemapContext = sitemapContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public SitemapModel SitemapItem { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.PageNumber == 0) == null)
            {
                SitemapItem.PageNumber = 0;
            }
            else
            {
                SitemapItem.PageNumber = _sitemapContext.Sitemaps.Max(y => y.PageNumber) + 1;
            }

            if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.Loc == SitemapItem.Loc) != null)
            {
                ModelState.AddModelError("SitemapItem.Loc", "Такая страница уже существует");

                return Page();
            }

            if (_imageContext.Images.FirstOrDefault(x => x.ImageId == SitemapItem.ImageModelImageId) == null)
            {
                ModelState.AddModelError("SitemapItem.ImageModelImageId", "Картинки с таким идентификатором не существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                _sitemapContext.AddSitemapItem(SitemapItem);

                return RedirectToPage("/DBCRUD/ViewPages");
            }
            else
            {
                return Page();
            }
        }
    }
}
