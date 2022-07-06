using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Legendy_Dublyaja
{
    [BindProperties(SupportsGet = true)]
    public class Tatiyana_IvanovaModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 230;
        }
    }
}