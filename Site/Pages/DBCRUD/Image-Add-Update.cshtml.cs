using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Image_Add_UpdateModel : PageModel
    {
        private readonly SiteContext _siteContext;
        public Image_Add_UpdateModel(SiteContext siteContext) => _siteContext = siteContext;

        public uint PageNumber { get; set; }

        public ImageModel Image { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? imageId)
        {
            PageNumber = 82;

            if (imageId.HasValue)
            {
                Image = await _siteContext.ImageModels.FirstOrDefaultAsync(p => p.ImageId == imageId);

                if (Image == null)
                {
                    return RedirectToPage("/DBCRUD/Image-Icons");
                }

                ViewData["Action"] = "Edit";

                return Page();
            }
            else
            {
                ViewData["Action"] = "Add";

                Image = new();

                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PageNumber = 82;

            if (Image.ImageId == Guid.Empty)
            {
                ViewData["Action"] = "Add";

                if (await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageContentUrl == Image.ImageContentUrl) != null)
                {
                    ModelState.AddModelError("Image.ImageContentUrl", "Такая картинка уже существует");

                    return Page();
                }

                if (await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageContentUrl == Image.ImageThumbnailUrl) != null)
                {
                    ModelState.AddModelError("Image.ImageContentUrl", "Такая картинка уже существует как иконка");

                    return Page();
                }

                if (await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageThumbnailUrl == Image.ImageThumbnailUrl) != null)
                {
                    ModelState.AddModelError("Image.ImageThumbnailUrl", "Такая иконка уже существует");

                    return Page();
                }

                if (await _siteContext.ImageModels.FirstOrDefaultAsync(x => x.ImageThumbnailUrl == Image.ImageContentUrl) != null)
                {
                    ModelState.AddModelError("Image.ImageThumbnailUrl", "Такая иконка уже существует как картинка");

                    return Page();
                }

                if (ModelState.IsValid)
                {
                    await _siteContext.ImageModels.AddAsync(Image);
                    await _siteContext.SaveChangesAsync();
                }
                else
                {
                    return Page();
                }
            }
            else
            {
                ViewData["Action"] = "Edit";

                ImageModel image = await _siteContext.ImageModels.FindAsync(Image.ImageId);

                image.ImageDescription = Image.ImageDescription;
                image.ImageCaption = Image.ImageCaption;
                image.ImageContentUrl = Image.ImageContentUrl;
                image.ImageWidth = Image.ImageWidth;
                image.ImageHeight = Image.ImageHeight;
                image.ImageThumbnailUrl = Image.ImageThumbnailUrl;
                image.ImageThumbnailWidth = Image.ImageThumbnailWidth;
                image.ImageThumbnailHeight = Image.ImageThumbnailHeight;
                image.ImageAlt = Image.ImageAlt;

                await _siteContext.SaveChangesAsync();
            }

            return RedirectToPage("/DBCRUD/Image-Icons");
        }
    }
}