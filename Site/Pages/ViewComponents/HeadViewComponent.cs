using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class Head : ViewComponent
    {
        private readonly IHeadModelRepository _context;

        public Head(IHeadModelRepository headModelRepository)
        {
            _context = headModelRepository;
        }

        public IViewComponentResult Invoke(uint? pageId)
        {
            if (pageId == null)
            {
                pageId = 1;
            }

            HeadModel head = _context.HeadModels.FirstOrDefault(x => x.PageId == pageId);

            return View(head);
        }
    }
}
