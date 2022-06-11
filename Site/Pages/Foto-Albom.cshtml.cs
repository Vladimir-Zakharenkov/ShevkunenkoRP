using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages
{
    public class Foto_AlbomModel : PageModel
    {
        private readonly SiteContext _siteContext;
        public Foto_AlbomModel(SiteContext siteContext) => _siteContext = siteContext;

        public uint PageNumber { get; set; }

        public IList<ImageModel> Images { get; set; }


        public async Task OnGetAsync()
        {
            Images = await _siteContext.ImageModels.AsAsyncEnumerable().Where(i => i.ImageContentUrl.Segments.Contains("FotoAlbom/")).Where(i => i.ImageHeight == 540).ToListAsync();

            PageNumber = 210;
        }
    }
}