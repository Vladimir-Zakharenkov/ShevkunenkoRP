using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Lihie_90_e
{
    [BindProperties(SupportsGet = true)]
    public class Delo_goluboy_orhideiModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 86;
        }
    }
}