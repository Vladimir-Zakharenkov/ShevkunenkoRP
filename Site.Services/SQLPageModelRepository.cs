using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<PageModel> Pages => _siteContext.PageModels.Include(p => p.ImageModel).Include(r => r.HeadModel);

        public PageModel GetPage(uint? pageNumber)
        {
            return _siteContext.PageModels.Include(p => p.ImageModel).Include(r => r.HeadModel).FirstOrDefault(x => x.PageNumber == pageNumber);
        }
    }
}