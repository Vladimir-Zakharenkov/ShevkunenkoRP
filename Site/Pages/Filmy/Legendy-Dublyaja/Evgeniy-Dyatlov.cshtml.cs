using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Legendy_Dublyaja
{
    [BindProperties(SupportsGet = true)]
    public class Evgeniy_DyatlovModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 293;
        }
    }
}