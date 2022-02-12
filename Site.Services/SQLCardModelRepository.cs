using Site.Models;
using System.Collections.Generic;
using System.Linq;

namespace Site.Services
{
    public class SQLCardModelRepository : ICardModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLCardModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public IEnumerable<CardModel> Cards => _siteContext.CardModels;

        public CardModel GetCard(string imageName)
        {
            if (_siteContext.CardModels.FirstOrDefault(z => z.ImageName == imageName) == null)
            {
                return null;
            }

            return _siteContext.CardModels.FirstOrDefault(z => z.ImageName == imageName);
        }
    }
}