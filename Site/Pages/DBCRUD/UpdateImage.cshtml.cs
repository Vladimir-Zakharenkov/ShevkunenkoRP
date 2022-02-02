using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System;

namespace Site.Pages.DBCRUD
{
    public class UpdateImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;
        private readonly ISitemapModelRepository _sitemapContext;
        public UpdateImageModel(IImageModelRepository imageContext, ISitemapModelRepository sitemapContext)

        {
            _imageContext = imageContext;
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        [BindProperty]
        public ImageModel ImageToUpdate { get; set; }

        public IActionResult OnGet(Guid imageID, uint? pageNumber = 8)
        {
            if (_imageContext.GetImage(imageID) == null)
            {
                return RedirectToPage("/DBCRUD/ViewImages");
            }

            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            ImageToUpdate = _imageContext.GetImage(imageID);

            return Page();
        }

        public IActionResult OnPost(ImageModel ImageToUpdate, uint? pageNumber = 8)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            if (ModelState.IsValid)
            {
                _imageContext.UpdateImage(ImageToUpdate);

                return RedirectToPage("/DBCRUD/ViewImages");
            }
            else
            {
                return Page();
            }
        }
    }
}