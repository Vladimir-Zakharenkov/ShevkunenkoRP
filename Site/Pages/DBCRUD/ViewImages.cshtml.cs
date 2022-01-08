using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;

namespace Site.Pages.DBCRUD
{
    public class ViewImagesModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;

        public ViewImagesModel(IImageModelRepository imageContext)
        {
            _imageContext = imageContext;
        }

        [BindProperty]
        public uint PageNumber { get; set; } = 1;

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        public IEnumerable<ImageModel> AllImages { get; set; }

        public void OnGet()
        {
            AllImages = _imageContext.Images;
        }
    }
}