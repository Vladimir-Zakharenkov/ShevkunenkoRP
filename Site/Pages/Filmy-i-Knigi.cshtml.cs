using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class Filmy_i_KnigiModel : PageModel
    {
        public uint PageNumber { get; set; }

        public void OnGet()
        {
            PageNumber = 159;
        }
    }
}