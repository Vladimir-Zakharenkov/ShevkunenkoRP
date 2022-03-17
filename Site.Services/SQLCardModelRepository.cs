﻿using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<CardModel> Cards => _siteContext.CardModels.Include(p => p.ImageModel);

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
            CardModel card = _siteContext.CardModels.Find(cardToUpdate.CardId);

            card.ImageName = cardToUpdate.ImageName;
            card.ImageModelImageId = cardToUpdate.ImageModelImageId;
            card.CardLink = cardToUpdate.CardLink;
            card.CardBody = cardToUpdate.CardBody;
            card.CardText = cardToUpdate.CardText;
            card.CardMovie = cardToUpdate.CardMovie;
            card.MovieCaption = cardToUpdate.MovieCaption;

            //var entry = _siteContext.CardModels.First(e => e.CardId == cardToUpdate.CardId);
            //_siteContext.Entry(entry).CurrentValues.SetValues(cardToUpdate);

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

        public CardModel GetCardByFileName(string fileName)
        {
            CardModel card = Cards.FirstOrDefault(y => y.ImageModel.ImageContentUrl.Segments.Last() == fileName);

            if (card == null)
            {
                card = Cards.FirstOrDefault(y => y.ImageModel.ImageContentUrl.Segments.Last() == "no-image.png");
            }

            return card;
        }
    }
}