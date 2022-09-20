using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Rybakov
{
    public class IndexModel : PageModel
    {
        public uint PageNumber
        {
            get; set;
        }
        public void OnGet()
        {
            PageNumber = 308;
        }
    }
}