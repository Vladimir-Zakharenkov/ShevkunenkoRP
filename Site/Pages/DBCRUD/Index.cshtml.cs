using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    public class IndexModel : PageModel
    {

        private readonly IImageModelRepository _imageContext;
        private readonly ISitemapModelRepository _sitemapContext;

        public IndexModel(IImageModelRepository imageContext, ISitemapModelRepository sitemapContext)
        {
            _imageContext = imageContext;
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }


        public IActionResult OnGet(uint? pageNumber = 11)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            return Page();
        }
    }
}
