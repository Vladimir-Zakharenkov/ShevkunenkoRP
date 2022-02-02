using Microsoft.EntityFrameworkCore;
using Site.Models;
using System.Linq;

namespace Site.Services
{
    public class SQLCardModelRepository : ICardModelRepository
    {
        private readonly SiteContext _siteContext;

        public SQLCardModelRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }

        public CardModel GetCard(string cardName)
        {
            return _siteContext.CardModels.Include(x => x.ImageModel).FirstOrDefault(z => z.CardName == cardName);
        }
    }
}