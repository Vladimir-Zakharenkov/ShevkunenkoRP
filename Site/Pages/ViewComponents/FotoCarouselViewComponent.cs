using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Site.Models;
using Site.Services;
using System;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class FotoCarousel : ViewComponent
    {
        private readonly IImageModelRepository _imageContext;

        public FotoCarousel(IImageModelRepository imageContext)
        {
            _imageContext = imageContext;
        }

        //public IViewComponentResult Invoke(string idForCarousel, string imageCatalog, bool imageThumbnail)
        //{
        //    ImageModel[] images =_imageContext.Images.Where(i => i.ImageContentUrl.Segments.Contains(imageCatalog)).ToArray();

        //    ViewData["idForCarousel"] = idForCarousel;

        //    ViewData["imageThumbnail"] = imageThumbnail;

        //    return View(images);
        //}

        public IViewComponentResult Invoke(string idForCarousel, string imageCatalog, bool imageThumbnail)
        {
            ImageModel[] images = _imageContext.Images.Where(i => i.ImageContentUrl.Segments.Contains(imageCatalog)).ToArray();

            ViewData["idForCarousel"] = idForCarousel;

            ViewData["imageThumbnail"] = imageThumbnail;

            return View(images);
        }
    }
}