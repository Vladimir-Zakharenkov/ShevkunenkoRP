using Site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Site.Services
{
    public class SQLPageModelRepository : IPageModelRepository
    {
        private readonly SiteContext _siteContext;

        public SQLPageModelRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }

        public IEnumerable<PageModel> Pages => _siteContext.PageModels;

        public PageModel GetPage(uint pageNumber)
        {
            return _siteContext.PageModels.FirstOrDefault(x => x.PageNumber == pageNumber);
        }
    }
}