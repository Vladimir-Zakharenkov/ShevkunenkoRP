using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Pervaya_krov
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {
        public uint PageNumber { get; set; }

        public void OnGet()
        {
            PageNumber = 1;
        }
    }
}