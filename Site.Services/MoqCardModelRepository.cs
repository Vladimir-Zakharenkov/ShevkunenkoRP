using Site.Models;
using System.Collections.Generic;
using System;

namespace Site.Services
{
    public class MoqCardModelRepository : ICardModelRepository
    {
        private List<CardModel> _cardList;

        public MoqCardModelRepository()
        {
            _cardList = new List<CardModel>()
            {
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "main",
                    CardLink = "https://shevkunenko.site/Main2",
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
                    CardId = Guid.NewGuid(),
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
                    CardId = Guid.NewGuid(),
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
                },
                new CardModel()
                {
                    CardId =Guid.NewGuid(),
                    CardName = "pressa",
                    CardLink = "https://shevkunenko.ru/pressa/index.htm",
                    ImageCaption = "Книги и статьи о Сергее Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/pressa-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/pressa-page.png",
                    ImagelUrl = "https://shevkunenko.site/images/cards/pressa-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/pressa-page.png",
                    ImageAlt = "Книги и статьи о Сергее Шевкуненко",
                    ImageTitle = "Книги и статьи о Сергее Шевкуненко",
                    CardBody = true,
                    CardText = "ПРЕССА"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "photo",
                    CardLink = "http://shevkunenko.ru/csfilm/album1.htm",
                    ImageCaption = "Фотографии Сергея Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/foto-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/foto-page.png",
                    ImagelUrl = "https://shevkunenko.site/images/cards/foto-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/foto-page.png",
                    ImageAlt = "Фотографии Сергея Шевкуненко",
                    ImageTitle = "Фотографии Сергея Шевкуненко",
                    CardBody = true,
                    CardText = "ФОТО"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "guestbook",
                    CardLink = "http://xbase.ru/?vladimirz",
                    ImageCaption = "Гостевая книга сайта",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/gostevaya-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/gostevaya-page.png",
                    ImagelUrl = "https://shevkunenko.site/images/cards/gostevaya-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/gostevaya-page.png",
                    ImageAlt = "Гостевая книга сайта",
                    ImageTitle = "Гостевая книга сайта",
                    CardBody = true,
                    CardText = "ГОСТЕВАЯ"
                }
            };
        }

        public IEnumerable<CardModel> GetAllCards()
        {
            return _cardList;
        }
    }
}
