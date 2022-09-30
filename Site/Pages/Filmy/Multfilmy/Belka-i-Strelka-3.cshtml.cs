using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Multfilmy
{
    [BindProperties(SupportsGet = true)]
    public class Belka_i_Strelka_3Model : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 309;
        }
    }
}