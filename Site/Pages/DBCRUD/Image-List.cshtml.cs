using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    public class Image_ListModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public Image_ListModel(IImageModelRepository imageContext) => _imageContext = imageContext;

        public uint PageNumber { get; set; }

        public IEnumerable<ImageModel> AllImages { get; set; }

        public void OnGet()
        {
            PageNumber = 83;

            AllImages = _imageContext.Images.ToArray();
        }
    }
}