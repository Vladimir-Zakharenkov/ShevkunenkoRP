using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Sovetskie_Filmy
{
    [BindProperties(SupportsGet = true)]
    public class Lev_Tolstoy_fonoModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 304;
        }
    }
}