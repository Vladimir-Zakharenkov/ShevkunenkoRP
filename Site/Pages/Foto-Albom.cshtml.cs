using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages
{
    public class Foto_AlbomModel : PageModel
    {
        private readonly IImageModelRepository _imageContext;
        public Foto_AlbomModel(IImageModelRepository imageContext) => _imageContext = imageContext;
        public uint PageNumber { get; set; }

        public IEnumerable<ImageModel> Images { get; set; }


        public void OnGet()
        {
            Images = _imageContext.Images.Where(i => i.ImageContentUrl.Segments.Contains("FotoAlbom")).Where(i => i.ImageHeight == 540);

            PageNumber = 210;
        }
    }
}