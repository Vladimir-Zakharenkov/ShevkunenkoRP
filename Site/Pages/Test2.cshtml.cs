using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class TestModel : PageModel
    {
        [BindProperty]
        public int[] CategoryId { get; set; } = new int[0];
        public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["categoryId"] = CategoryId;
        }

    }
}
