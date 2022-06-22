using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.SergeyYurskiy
{
    [BindProperties(SupportsGet = true)]
    public class Chelovek_niotkudaModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 220;
        }
    }
}