using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Lihie_90_e
{
    [BindProperties(SupportsGet = true)]
    public class Show_biznes_po_russkiModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 77;
        }
    }
}