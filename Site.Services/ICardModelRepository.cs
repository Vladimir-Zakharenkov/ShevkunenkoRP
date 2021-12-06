using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface ICardModelRepository
    {
        IEnumerable<CardModel> GetAllCards();
    }
}
