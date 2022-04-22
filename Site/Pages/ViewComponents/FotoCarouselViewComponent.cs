using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Site.Models;
using Site.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.ViewComponents
{
    public class FotoCarousel : ViewComponent
    {
        private readonly IImageModelRepository _imageContext;

        public FotoCarousel(IImageModelRepository imageContext)
        {
            _imageContext = imageContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(string idForCarousel, string imageCatalog, bool imageThumbnail)
        {
            ImageModel[] images = _imageContext.Images.Where(i => i.ImageContentUrl.Segments.Contains(imageCatalog)).ToArray();

            ImageModel[] images1 = new ImageModel[6];

            Random rand = new Random();

            //Copy(Array, Int32, Array, Int32, Int32)
            Array.Copy(images, rand.Next(0, (images.Length - 6)), images1, 0, 6);

            ViewData["idForCarousel"] = idForCarousel;

            ViewData["imageThumbnail"] = imageThumbnail;

            return await Task.Run(() => View(images1));
        }
    }
}