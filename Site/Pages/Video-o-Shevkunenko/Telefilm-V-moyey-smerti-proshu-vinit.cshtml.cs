using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Telefilm_V_moyey_smerti_proshu_vinitModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 51;
        }
    }
}