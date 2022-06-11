using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class FotoCarousel : ViewComponent
    {
        private readonly IImageModelRepository _imageContext;
        public FotoCarousel(IImageModelRepository imageContext) => _imageContext = imageContext;

        public IViewComponentResult Invoke(string idForCarousel, string imageCatalog, bool imageThumbnail)
        {
            ImageModel[] images = _imageContext.Images.ToEnumerable().Where(i => i.ImageContentUrl.Segments.Contains(imageCatalog)).Where(i => i.ImageHeight == 540).ToArray();

            ImageModel[] images1 = new ImageModel[5];

            Random rand = new();

            if (images.Length >= 10)
            {
                Array.Copy(images, rand.Next(0, (images.Length - 4)), images1, 0, 5);
            }
            else
            {
                Array.Copy(images, 0, images1, 0, 5);
            }

            ViewData["idForCarousel"] = idForCarousel;

            ViewData["imageThumbnail"] = imageThumbnail;

            return View(images1);
        }
    }
}