using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Legendy_Dublyaja
{
    [BindProperties(SupportsGet = true)]
    public class Yaroslava_Turyleva_1Model : PageModel
    {
        public uint PageNumber { get; set; } = 167;

        public string VideoProvider { get; set; }

        public void OnGet()
        {
        }
    }
}