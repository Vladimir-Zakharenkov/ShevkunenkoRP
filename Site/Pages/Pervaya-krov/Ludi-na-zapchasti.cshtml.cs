using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Pervaya_krov
{
    [BindProperties(SupportsGet = true)]
    public class Ludi_na_zapchastiModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 60;
        }
    }
}