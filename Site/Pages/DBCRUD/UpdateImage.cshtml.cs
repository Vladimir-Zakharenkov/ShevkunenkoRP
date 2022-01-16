using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System;

namespace Site.Pages.DBCRUD
{
    public class UpdateImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IImageModelRepository _imageContext;

        public UpdateImageModel(IImageModelRepository imageRepository)
        {
            _imageContext = imageRepository;
        }

        [BindProperty]
        public uint PageNumber { get; set; } = 1;

        [BindProperty]
        public string PageImage { get; set; } = "main-index";

        [BindProperty]
        public ImageModel Image { get; set; }


        public void OnGet(Guid imageId)
        {
            Image = _imageContext.GetImage(imageId);
        }

        public IActionResult OnPost(ImageModel image)
        {
            if (ModelState.IsValid)
            {
                //ImageModel compareImage = _imageContext.GetImage(image.ImageId);
                //compareImage.ImageName = image.ImageName;
                //compareImage.ImageName2 = image.ImageName2;
                //compareImage.ImageDescription = image.ImageDescription;
                //compareImage.ImageCaption = image.ImageCaption;
                //compareImage.ImageContentUrl = image.ImageContentUrl;
                //compareImage.ImageThumbnailUrl = image.ImageThumbnailUrl;
                //compareImage.ImageWidth = image.ImageWidth;
                //compareImage.ImageHeight = image.ImageHeight;
                //compareImage.ImageSrc = image.ImageSrc;
                //compareImage.ImageAlt = image.ImageAlt;
                //compareImage.ImageTitle = image.ImageTitle;

                _imageContext.UpdateImage(image);

                return RedirectToPage("ViewImages");
            }
            else
            {
                return base.Page();
            }
        }
    }
}