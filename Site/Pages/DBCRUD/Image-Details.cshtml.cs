using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Threading.Tasks;

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

        public async Task<IActionResult> OnGetAsync()
        {
            PageNumber = 7;

            Image = await _imageContext.GetImageAsync(Image.ImageId);

            if (Image == null)
            {
                return RedirectToPage("Image-Icons");
            }

            return Page();
        }
    }
}