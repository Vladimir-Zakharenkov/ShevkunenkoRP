using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Rybakov
{
    public class KortikModel : PageModel
    {
        public uint PageNumber
        {
            get; set;
        }
        public void OnGet()
        {
            PageNumber = 98;
        }
    }
}