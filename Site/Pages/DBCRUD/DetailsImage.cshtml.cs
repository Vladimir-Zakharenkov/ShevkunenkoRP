using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System;

namespace Site.Pages.DBCRUD
{
    public class DetailsImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;
        private readonly ISitemapModelRepository _sitemapContext;

        public DetailsImageModel(IImageModelRepository imageContext, ISitemapModelRepository sitemapContext)
        {
            _imageContext = imageContext;
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }

        public IActionResult OnGet(Guid imageID, uint? pageNumber = 7)
        {
            if (_imageContext.GetImage(imageID) == null)
            {
                imageID = new Guid("7f919234-f469-4c90-2b71-08d9cfc07d7c"); ;
            }

            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            Image = _imageContext.GetImage(imageID);

            return Page();
        }
    }
}