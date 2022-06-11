using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Site.Models;
using Site.Services;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class Image_IconsModel : PageModel
    {
        private readonly SiteContext _siteContext;
        public Image_IconsModel(SiteContext siteContext) => _siteContext = siteContext;

        public uint PageNumber { get; set; }

        public IEnumerable<ImageModel> AllImages { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            PageNumber = 6;

            AllImages = await _siteContext.ImageModels.ToArrayAsync();

            return Page();
        }
    }
}