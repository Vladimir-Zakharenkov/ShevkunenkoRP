using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface ICardRepository
    {
        IEnumerable<CardModel> GetAllCards();
    }
}
