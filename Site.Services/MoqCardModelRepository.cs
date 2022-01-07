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
                    MovieName = string.Empty,
                    CardLink = "/Main2",
                    CardBody = true,
                    CardText = "САЙТ"

                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "biografy",
                    ImageName = "biografy-page",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/biografy.htm",
                    CardBody = true,
                    CardText = "БИОГРАФИЯ"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "characters",
                    ImageName = "films-page",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/online/index.htm",
                    CardBody = true,
                    CardText = "РОЛИ В КИНО"
                },
                new CardModel()
                {
                    CardId =Guid.NewGuid(),
                    CardName = "pressa",
                    ImageName = "pressa-page",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/pressa/index.htm",
                    CardBody = true,
                    CardText = "ПРЕССА"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "photo",
                    ImageName = "foto-page",
                    MovieName = string.Empty,
                    CardLink = "http://shevkunenko.ru/csfilm/album1.htm",
                    CardBody = true,
                    CardText = "ФОТО"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "guestbook",
                    ImageName = "gostevaya-page",
                    MovieName = string.Empty,
                    CardLink = "http://xbase.ru/?vladimirz",
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
                    CardBody = false,
                    CardText = "КРИМИНАЛЬНАЯ ЗВЕЗДА"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "programs",
                    ImageName = "programs",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/csfilm/online.htm",
                    CardBody = true,
                    CardText = "ПРОГРАММЫ"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "znakomye",
                    ImageName = "znakomye",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/csfilm/people.htm",
                    CardBody = true,
                    CardText = "ЗНАКОМЫЕ"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "raznoe",
                    ImageName = "raznoe",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/raznoe.htm",
                    CardBody = true,
                    CardText = "РАЗНОЕ..."
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "kalinin",
                    ImageName = "kalinin",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/krfilm/persons/kalinin/index.htm",
                    CardBody = true,
                    CardText = "НИКОЛАЙ КАЛИНИН"
                },
                new CardModel()
                {
                    CardId = Guid.NewGuid(),
                    CardName = "rybakov",
                    ImageName = "rybakov",
                    MovieName = string.Empty,
                    CardLink = "https://shevkunenko.ru/rybakov/index.htm",
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