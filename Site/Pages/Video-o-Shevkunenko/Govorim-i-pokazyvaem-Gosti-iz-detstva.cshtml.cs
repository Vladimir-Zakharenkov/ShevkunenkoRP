using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages.Video_o_Shevkunenko
{
    [BindProperties(SupportsGet = true)]
    public class Govorim_i_pokazyvaem_Gosti_iz_detstvaModel : PageModel
    {
        public uint PageNumber { get; set; }

        public string MovieCaption { get; set; }

        public string VideoProvider { get; set; }

        public void OnGet()
        {
            PageNumber = 41;

            MovieCaption = "��������� �������� � ���������� �� 05.10.2011";
        }
    }
}