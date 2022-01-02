using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class Head : ViewComponent
    {
        public IHeadModelRepository Context { get; }

        public Head(IHeadModelRepository context) => Context = context;

        public IViewComponentResult Invoke(uint? pageId)
        {
            if (pageId == null)
            {
                pageId = 1;
            }

            HeadModel head = Context.HeadModels.FirstOrDefault(x => x.PageId == pageId);

            return View(head);
        }
    }
}
