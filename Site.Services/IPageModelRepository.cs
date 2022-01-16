using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface IPageModelRepository
    {
        public IEnumerable<PageModel> Pages { get; }

        PageModel GetPage(uint pageNumber);
    }
}
