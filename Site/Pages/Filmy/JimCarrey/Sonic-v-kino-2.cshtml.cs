using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.JimCarrey
{
    [BindProperties(SupportsGet = true)]
    public class Sonic_v_kino_2Model : PageModel
    {
        public uint PageNumber { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 187;
        }
    }
}