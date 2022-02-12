using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface ICardModelRepository
    {
        public IEnumerable<CardModel> Cards { get; }

        CardModel GetCard(string cardName);
    }
}