using Site.Models;

namespace Site.Services
{
    public interface ICardModelRepository
    {
        CardModel GetCard(string cardName);
    }
}