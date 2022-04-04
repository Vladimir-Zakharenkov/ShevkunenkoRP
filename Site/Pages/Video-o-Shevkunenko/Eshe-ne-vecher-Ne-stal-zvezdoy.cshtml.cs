using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Eshe_ne_vecher_Ne_stal_zvezdoyModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 39;
        }
    }
}