using Site.Models;
using System.Linq;

namespace Site.Services
{
    public class SQLCardModelRepository : ICardModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLCardModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public CardModel GetCard(string imageName)
        {
            return _siteContext.CardModels.FirstOrDefault(z => z.ImageName == imageName);
        }
    }
}