using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Filmy.Sovetskie_Filmy
{
    public class Lev_TolstoyModel : PageModel
    {
        public uint PageNumber
        {
            get; set;
        }
        public void OnGet()
        {
            PageNumber = 301;
        }
    }
}