using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Services
{
    public interface ICardModelRepository
    {
        public IEnumerable<CardModel> Cards { get; }

        CardModel GetCard(string cardName);

        CardModel GetCardById(Guid? cardId);

        void AddCard(CardModel card);

        void UpdateCard(CardModel card);

        void DeleteCard(Guid cardId);
    }
}