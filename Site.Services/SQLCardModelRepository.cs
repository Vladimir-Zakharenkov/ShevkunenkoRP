using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Site.Services
{
    public class SQLCardModelRepository : ICardModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLCardModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public IEnumerable<CardModel> Cards => _siteContext.CardModels;

        public void AddCard(CardModel card)
        {
            _siteContext.CardModels.Add(card);
            _siteContext.SaveChanges();
        }

        public void DeleteCard(Guid cardId)
        {
            var cardToDelete = _siteContext.CardModels.Find(cardId);

            _siteContext.CardModels.Remove(cardToDelete);
            _siteContext.SaveChanges();
        }

        public void UpdateCard(CardModel cardToUpdate)
        {
            var entry = _siteContext.CardModels.First(e => e.CardId == cardToUpdate.CardId);
            _siteContext.Entry(entry).CurrentValues.SetValues(cardToUpdate);
            _siteContext.SaveChanges();
        }

        public CardModel GetCard(string imageName)
        {
            if (_siteContext.CardModels.FirstOrDefault(z => z.ImageName == imageName) == null)
            {
                return null;
            }

            return _siteContext.CardModels.FirstOrDefault(z => z.ImageName == imageName);
        }

        public CardModel GetCardById(Guid? cardId)
        {
            if (_siteContext.CardModels.FirstOrDefault(z => z.CardId == cardId) == null)
            {
                return null;
            }

            return _siteContext.CardModels.FirstOrDefault(z => z.CardId == cardId);
        }
    }
}