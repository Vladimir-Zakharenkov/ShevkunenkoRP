using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Security.Claims;

namespace Site.Pages.DBCRUD
{
    [BindProperties(SupportsGet = true)]
    public class LoginModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        private readonly IAdminAccessRepository _adminContext;

        public LoginModel(ISitemapModelRepository sitemapContext, IAdminAccessRepository adminContext)
        {
            _sitemapContext = sitemapContext;
            _adminContext = adminContext;
        }

        public uint PageNumber { get; set; }

        public AdminAccess Admin { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                AdminAccess admin = _adminContext.GetAdmin(Admin);

                if (admin != null)
                {
                    Authenticate(admin.Email); // ��������������

                    return RedirectToPage("/DBCRUD/Index");
                }
                else
                {
                    //ModelState.AddModelError("", "������������ ����� �(���) ������");
                    ModelState.AddModelError("Admin.Password", "������������ ����� �(���) ������");

                    return Page();
                }
            }

            return Page();
        }

        private void Authenticate(string userName)
        {
            // ������� ���� claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            // ������� ������ ClaimsIdentity
            ClaimsIdentity id = new(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            // ��������� ������������������ ����
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToPage("/Index");
        }
    }
}
