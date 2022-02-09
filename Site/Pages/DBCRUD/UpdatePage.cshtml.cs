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
    public class UpdatePageModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IImageModelRepository _imageContext;
        public UpdatePageModel(ISitemapModelRepository sitemapContext, IImageModelRepository imageContext)
        {
            _sitemapContext = sitemapContext;
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public SitemapModel PageToUpdate { get; set; }

        public string ImageForPage { get; set; }

        public IActionResult OnGet(Guid? sitemapModelId)
        {
            if (sitemapModelId == null || _sitemapContext.Sitemaps.FirstOrDefault(x => x.SitemapModelId == sitemapModelId) == null)
            {
                return RedirectToPage("ViewPages");
            }

            PageNumber = _sitemapContext.GetPageById(sitemapModelId).PageNumber;

            PageToUpdate = _sitemapContext.GetPageById(sitemapModelId);

            ImageForPage = _sitemapContext.GetPage(PageNumber).ImageModel.ImageName;

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            ImageForPage = _sitemapContext.GetPage(PageNumber).ImageModel.ImageName;

            if (_imageContext.Images.FirstOrDefault(x => x.ImageId == PageToUpdate.ImageModelImageId) == null)
            {
                ModelState.AddModelError("PageToUpdate.ImageModelImageId", "Картинки с таким идентификатором не существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                _sitemapContext.UpdatePage(PageToUpdate);

                return RedirectToPage("/DBCRUD/ViewPages");
            }
            else
            {
                return Page();
            }
        }
    }
}