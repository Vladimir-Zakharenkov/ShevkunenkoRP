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
    public class Image_ListModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public Image_ListModel(IImageModelRepository imageContext) => _imageContext = imageContext;

        public uint PageNumber { get; set; }

        public IList<ImageModel> AllImages { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ImageCaptionSearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ImageDescriptionSearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ImageContentUrlSearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ImageThumbnailUrlSearchString { get; set; }

        public SelectList ImageWidthList { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? ImageWidthSearchString { get; set; }

        public SelectList ImageHeightList { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? ImageHeightSearchString { get; set; }

        public async Task OnGetAsync()
        {
            PageNumber = 83;

            var heightQuery = from w in _imageContext.Images
                             orderby w.ImageHeight
                             select w.ImageHeight;

            var widthQuery = from w in _imageContext.Images
                             orderby w.ImageWidth
                             select w.ImageWidth;

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

            ImageWidthList = new SelectList(await widthQuery.Distinct().ToListAsync());

            if (ImageHeightSearchString != null)
            {
                allimages = allimages.Where(s => s.ImageHeight == ImageHeightSearchString);
            }

            ImageHeightList = new SelectList(await heightQuery.Distinct().ToListAsync());

            AllImages = await allimages.ToListAsync();
        }
    }
}