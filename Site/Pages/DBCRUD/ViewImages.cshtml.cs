using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class ViewImagesModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;
        private readonly ISitemapModelRepository _sitemapContext;
        public ViewImagesModel(IImageModelRepository imageContext, ISitemapModelRepository sitemapContext)
        {
            _imageContext = imageContext;
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public IEnumerable<ImageModel> AllImages { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            AllImages = _imageContext.Images.ToArray();

            return Page();
        }
    }
}