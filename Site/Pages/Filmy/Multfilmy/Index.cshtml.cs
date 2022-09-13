using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Multfilmy
{
    public class IndexModel : PageModel
    {
        public uint PageNumber { get; set; }

        public void OnGet()
        {
            PageNumber = 296;
        }
    }
}