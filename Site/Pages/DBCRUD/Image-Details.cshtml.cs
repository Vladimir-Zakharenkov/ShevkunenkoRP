using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class DetailsImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public DetailsImageModel(IImageModelRepository imageContext) => _imageContext = imageContext;

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 7;

            Image = _imageContext.GetImage(Image.ImageId);

            if (Image == null)
            {
                return RedirectToPage("Image-Icons");
            }

            return Page();
        }
    }
}