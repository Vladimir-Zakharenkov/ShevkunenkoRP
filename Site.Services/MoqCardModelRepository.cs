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
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "kortik",
                    ImageName = "kortik",
                    MovieName = "kortik",
                    CardLink = "https://shevkunenko.ru/krfilm/index.htm",
                    CardLinkHttp = true,
                    CardBody = false,
                    CardText = "КОРТИК"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "br-ptica",
                    ImageName = "br-ptica",
                    MovieName = "br-ptica",
                    CardLink = "https://shevkunenko.ru/bpfilm/index.htm",
                    CardLinkHttp = true,
                    CardBody = false,
                    CardText = "БРОНЗОВАЯ ПТИЦА"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "pr-expediciya",
                    ImageName = "pr-expediciya",
                    MovieName = "pr-expediciya",
                    CardLink = "https://shevkunenko.ru/pefilm.htm",
                    CardLinkHttp = true,
                    CardBody = false,
                    CardText = "ПРОПАВШАЯ ЭКСПЕДИЦИЯ"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "kr-zvezda",
                    ImageName = "kr-zvezda",
                    MovieName = "kr-zvezda",
                    CardLink = "https://shevkunenko.ru/csfilm/cs_online.htm",
                    CardLinkHttp = true,
                    CardBody = false,
                    CardText = "КРИМИНАЛЬНАЯ ЗВЕЗДА"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "programs",
                    ImageName = "programs",
                    CardLink = "https://shevkunenko.ru/csfilm/online.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "ПРОГРАММЫ"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "znakomye",
                    ImageName = "znakomye",
                    CardLink = "https://shevkunenko.ru/csfilm/people.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "ЗНАКОМЫЕ"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "raznoe",
                    ImageName = "raznoe",
                    CardLink = "https://shevkunenko.ru/raznoe.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "РАЗНОЕ..."
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "kalinin",
                    ImageName = "kalinin",
                    CardLink = "https://shevkunenko.ru/krfilm/persons/kalinin/index.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "НИКОЛАЙ КАЛИНИН"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "rybakov",
                    ImageName = "rybakov",
                    CardLink = "https://shevkunenko.ru/rybakov/index.htm",
                    CardLinkHttp = true,
                    CardBody = true,
                    CardText = "АНАТОЛИЙ РЫБАКОВ"
                }
            };
        }

        public IEnumerable<CardModel> GetAllCards()
        {
            return _cardList;
        }
    }
}
