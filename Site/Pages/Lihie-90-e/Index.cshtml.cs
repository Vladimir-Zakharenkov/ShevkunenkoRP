using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Lihie_90_e
{
    public class IndexModel : PageModel
    {
        public uint PageNumber { get; set; }
        public void OnGet()
        {
            PageNumber = 89;
        }
    }
}