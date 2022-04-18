using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class DeleteImageModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public DeleteImageModel(IImageModelRepository imageContext) => _imageContext = imageContext;

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            PageNumber = 10;

            Image = await _imageContext.GetImageAsync(Image.ImageId);

            if (Image == null)
            {
                return RedirectToPage("Image-Icons");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PageNumber = 10;

            await _imageContext.DeleteImageAsync(Image.ImageId);

            return RedirectToPage("Image-Icons");
        }
    }
}