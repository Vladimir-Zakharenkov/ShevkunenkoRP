using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Image_ListModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public Image_ListModel(IImageModelRepository imageContext) => _imageContext = imageContext;

        public uint PageNumber { get; set; } = 83;

        public IList<ImageModel> AllImages { get; set; }

        public string ImageCaptionSearchString { get; set; }

        public string ImageDescriptionSearchString { get; set; }

        public string ImageContentUrlSearchString { get; set; }

        public string ImageThumbnailUrlSearchString { get; set; }

        [BindProperty(SupportsGet = false)]
        public SelectList ImageWidthList { get; set; }

        public int? ImageWidthSearchString { get; set; }

        [BindProperty(SupportsGet = false)]
        public SelectList ImageHeightList { get; set; }

        public int? ImageHeightSearchString { get; set; }

        public async Task OnGetAsync()
        {
            var heightQuery = from w in _imageContext.Images
                              orderby w.ImageHeight
                              select w.ImageHeight;

            ImageHeightList = new SelectList(await heightQuery.Distinct().ToListAsync());

            var widthQuery = from w in _imageContext.Images
                             orderby w.ImageWidth
                             select w.ImageWidth;

            ImageWidthList = new SelectList(await widthQuery.Distinct().ToListAsync());

            var allimages = from img in _imageContext.Images
                            select img;

            if (!string.IsNullOrEmpty(ImageCaptionSearchString))
            {
                allimages = allimages.Where(s => s.ImageCaption.Contains(ImageCaptionSearchString));
            }

            if (!string.IsNullOrEmpty(ImageDescriptionSearchString))
            {
                allimages = allimages.Where(s => s.ImageDescription.Contains(ImageDescriptionSearchString));
            }

            if (!string.IsNullOrEmpty(ImageContentUrlSearchString))
            {
                allimages = allimages.Where(s => s.ImageContentUrl.ToString().Contains(ImageContentUrlSearchString));
            }

            if (!string.IsNullOrEmpty(ImageThumbnailUrlSearchString))
            {
                allimages = allimages.Where(s => s.ImageThumbnailUrl.ToString().Contains(ImageThumbnailUrlSearchString));
            }

            if (ImageWidthSearchString != null)
            {
                allimages = allimages.Where(s => s.ImageWidth == ImageWidthSearchString);
            }

            if (ImageHeightSearchString != null)
            {
                allimages = allimages.Where(s => s.ImageHeight == ImageHeightSearchString);
            }

            AllImages = await allimages.ToListAsync();
        }
    }
}