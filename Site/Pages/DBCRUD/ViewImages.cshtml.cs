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
        public ViewImagesModel(IImageModelRepository imageContext)
        {
            _imageContext = imageContext;
        }

        public uint PageNumber { get; set; }

        public IEnumerable<ImageModel> AllImages { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 6;

            AllImages = _imageContext.Images.ToArray();

            return Page();
        }
    }
}