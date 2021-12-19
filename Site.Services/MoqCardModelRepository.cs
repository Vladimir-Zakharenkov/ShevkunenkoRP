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
                    ImageName = "main-page",
                    CardLink = "/Main2",
                    CardLinkHttp = false,
                    CardBody = true,
                    CardText = "САЙТ"

                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "biografy",
                    ImageName = "biografy-page",
                    CardLink = "https://shevkunenko.ru/biografy.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "БИОГРАФИЯ"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "characters",
                    ImageName = "films-page",
                    CardLink = "https://shevkunenko.ru/online/index.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "РОЛИ"
                },
                new CardModel()
                {
                    CardId =Guid.NewGuid(),
                    CardName = "pressa",
                    ImageName = "pressa-page",
                    CardLink = "https://shevkunenko.ru/pressa/index.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "ПРЕССА"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "photo",
                    ImageName = "foto-page",
                    CardLink = "http://shevkunenko.ru/csfilm/album1.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "ФОТО"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "guestbook",
                    ImageName = "gostevaya-page",
                    CardLink = "http://xbase.ru/?vladimirz",
                    CardLinkHttp = true,
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
