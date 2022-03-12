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
    public class Page_Add_UpdateModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public Page_Add_UpdateModel(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public uint PageNumber { get; set; }

        public SitemapModel SitemapItem { get; set; }

        public IActionResult OnGet(Guid? sitemapModelId)
        {
            PageNumber = 81;

            if (sitemapModelId.HasValue)
            {
                ViewData["Action"] = "Edit";

                SitemapItem = _sitemapContext.Sitemaps.FirstOrDefault(p => p.SitemapModelId == sitemapModelId);

                return Page();
            }
            else
            {
                ViewData["Action"] = "Add";

                SitemapItem = new();

                return Page();
            }
        }

        public IActionResult OnPost()
        {
            PageNumber = 81;

            if (SitemapItem.SitemapModelId == Guid.Empty)
            {
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
            }

            if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.ImageModelImageId == SitemapItem.ImageModelImageId) == null)
            {
                ModelState.AddModelError("SitemapItem.ImageModelImageId", "Картинки с таким GUID не существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                if (SitemapItem.SitemapModelId == Guid.Empty)
                {
                    _sitemapContext.AddSitemapItem(SitemapItem);
                }
                else
                {
                    _sitemapContext.UpdatePage(SitemapItem);
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