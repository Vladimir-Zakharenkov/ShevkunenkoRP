using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Head : ViewComponent
    {
        private readonly IPageModelRepository _pageContext;

        public Head(IPageModelRepository pageContext)
        {
            _pageContext = pageContext;
        }

        public IViewComponentResult Invoke(uint? pageNumber)
        {

            if (pageNumber == null)
            {
                pageNumber = 1;
            }

            PageModel PageModel = _pageContext.GetPage(pageNumber);

            return View(PageModel);
        }
    }
}