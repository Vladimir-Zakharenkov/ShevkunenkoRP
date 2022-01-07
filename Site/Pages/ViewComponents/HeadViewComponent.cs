using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class Head : ViewComponent
    {
        private readonly IImageModelRepository _imageContext;

        private readonly IHeadModelRepository _headContext;

        public Head(IHeadModelRepository headContext, IImageModelRepository imageContext)
        {
            _headContext = headContext;
            _imageContext = imageContext;
        }

        public IViewComponentResult Invoke(uint? pageId, string imageName)
        {
            if (pageId == null)
            {
                pageId = 1;
            }

            if (imageName == null)
            {
                imageName = "main-index";
            }

            HeadModel head = _headContext.HeadModels.FirstOrDefault(x => x.PageId == pageId);

            ImageModel imageHead = _imageContext.Images.FirstOrDefault(y => y.ImageName == imageName);

            ViewData["PageImage"] = imageHead.ImageContentUrl;
            ViewData["PageImageWidth"] = imageHead.ImageWidth;
            ViewData["PageImageHeight"] = imageHead.ImageHeight;

            return View(head);
        }
    }
}