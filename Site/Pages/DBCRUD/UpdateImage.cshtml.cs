using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [BindProperties(SupportsGet = true)]
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

        public ImageModel ImageToUpdate { get; set; }

        public IActionResult OnGet(Guid? imageId)
        {
            if (imageId == null || _imageContext.Images.FirstOrDefault(x => x.ImageId == imageId) == null)
            {
                return RedirectToPage("ViewImages");
            }

            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            ImageToUpdate = _imageContext.GetImage(imageId);

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            if (ModelState.IsValid)
            {
                _imageContext.UpdateImage(ImageToUpdate);

                return RedirectToPage("ViewImages");
            }

            return Page();
        }
    }
}