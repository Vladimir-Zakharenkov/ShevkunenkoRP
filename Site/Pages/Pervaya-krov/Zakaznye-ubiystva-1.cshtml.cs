using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Pervaya_krov
{
    [BindProperties(SupportsGet = true)]
    public class Zakaznye_ubiystva_1Model : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 52;
        }
    }
}