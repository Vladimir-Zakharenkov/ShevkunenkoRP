using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Services
{
    public class MoqCardModelRepository : ICardRepository
    {
        private List<CardModel> _cardList;

        public MoqCardModelRepository()
        {
            _cardList = new List<CardModel>()
            {
                new CardModel()
                {
                    CardId = System.Guid.NewGuid(),
                    CardName = "main",
                    CardLink = "/Main2",
                    ImageCaption = "Сайт, посвященный Сергею Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/main-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/main-page.png",
                    ImagelUrl = "https://shevkunenko.site/images/cards/main-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/main-page.png",
                    ImageAlt = "Сайт, посвященный Сергею Шевкуненко",
                    ImageTitle = "Сайт, посвященный Сергею Шевкуненко",
                    CardBody = true,
                    CardText = "САЙТ"

                },
                new CardModel()
                {
                    CardId = System.Guid.NewGuid(),
                    CardName = "biografy",
                    CardLink = "https://shevkunenko.ru/biografy.htm",
                    ImageCaption = "Биография Сергея Юрьевича Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/biografy-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/biografy-page.png",
                    ImagelUrl = "https://shevkunenko.site/images/cards/biografy-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/biografy-page.png",
                    ImageAlt = "Биография Сергея Юрьевича Шевкуненко",
                    ImageTitle = "Биография Сергея Юрьевича Шевкуненко",
                    CardBody = true,
                    CardText = "БИОГРАФИЯ"
                },
                new CardModel()
                {
                    CardId = System.Guid.NewGuid(),
                    CardName = "characters",
                    CardLink = "https://shevkunenko.ru/online/index.htm",
                    ImageCaption = "Фильмы с участием Сергея Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/films-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/films-page.png",
                    ImagelUrl = "https://shevkunenko.site/images/cards/films-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/films-page.png",
                    ImageAlt = "Фильмы с участием Сергея Шевкуненко",
                    ImageTitle = "Фильмы с участием Сергея Шевкуненко",
                    CardBody = true,
                    CardText = "РОЛИ"
                }
            };
        }

        public IEnumerable<CardModel> GetAllCards()
        {
            return _cardList;
        }
    }
}
