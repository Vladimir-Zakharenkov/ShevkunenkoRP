using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Services
{
    public class MoqMovieModelRepository : IMovieModelRepository
    {
        private List<MovieModel> _movieList;

        public MoqMovieModelRepository()
        {
            _movieList = new()
            {
                new MovieModel()
                {
                    MovieId = Guid.NewGuid(),
                    MovieName = "kortik",
                    ImageName = "kortik",
                    MovieCaption = "Кортик",
                    Duration = "T03H28M14S",
                    DatePublished = "1974-06-04",
                    DateCreated = "1973-01-01",
                    UploadDate = "2021-12-19",
                    IsFamilyFriendly = "true",
                    InLanguage = "ru",
                    РroductionCompany = "Беларусьфильм",
                    Director = "Николай Калинин",
                    MusicBy = "Станислав Пожлаков",
                    Genre = "приключения",
                    Description = "1921 год. Пионеры пытаются раскрыть тайну морского кортика, хранящего шифрованное послание. Но при этом им приходится то и дело вступать в противостояние с бандитами...",
                    Actor01 = "Михаил Голубович",
                    Actor02 = "Эммануил Виторган",
                    Actor03 = "Роман Филиппов",
                    Actor04 = "Сергей Шевкуненко",
                    Actor05 = "Владимир Дичковский",
                    Actor06 = "Игорь Шульженко",
                    Actor07 = "Зоя Фёдорова",
                    ContentUrl = "http://vladimirz.asuscomm.com/Video/kortik-1-seriya.mp4"
                },
                new MovieModel()
                {
                    MovieId = Guid.NewGuid(),
                    MovieName = "br-ptica",
                    ImageName = "br-ptica",
                    MovieCaption = "Бронзовая птица",
                    Duration = "T03H11M14S",
                    DatePublished = "1975-01-02",
                    DateCreated = "1974-09-09",
                    UploadDate = "2021-12-19",
                    IsFamilyFriendly = "true",
                    InLanguage = "ru",
                    РroductionCompany = "Беларусьфильм",
                    Director = "Николай Калинин",
                    MusicBy = "Станислав Пожлаков",
                    Genre = "приключения",
                    Description = "Друзья отправляются в пионерский лагерь под Москву. Это совершенно особенное место: бывшая дворянская усадьба графа Карагаева, в которой до сих пор живет старая дама, по слухам - сама графиня. Но самое интересное в том, что где-то рядом с усадьбой спрятан клад. Путь к нему должна указать бронзовая птица - старинная скульптура, установленная в усадьбе. Но как? Ответ будут искать пионеры.",
                    Actor01 = "Мария Капнист",
                    Actor02 = "Августин Милованов",
                    Actor03 = "Николай Крюков",
                    Actor04 = "Сергей Шевкуненко",
                    Actor05 = "Владимир Дичковский",
                    Actor06 = "Игорь Шульженко",
                    Actor07 = "Виктор Сергачёв",
                    ContentUrl = "http://vladimirz.asuscomm.com/Video/br-ptica-1-seriya.mp4"
                },
                new MovieModel()
                {
                    MovieId = Guid.NewGuid(),
                    MovieName = "pr-expediciya",
                    ImageName = "pr-expediciya",
                    MovieCaption = "Пропавшая экспедиция",
                    Duration = "T02H04M17S",
                    DatePublished = "1975-12-29",
                    DateCreated = "1975-01-01",
                    UploadDate = "2021-12-19",
                    IsFamilyFriendly = "true",
                    InLanguage = "ru",
                    РroductionCompany = "Киностудия имени Максима Горького",
                    Director = "Вениамин Дорман",
                    MusicBy = "Микаэл Таривердиев",
                    Genre = "приключения",
                    Description = "В 1918 году профессор Смелков возглавляет геологическую экспедицию к сибирской реке Ардыбаш, где по рассказам местных жителей есть золото. В ее составе - комиссар Арсен, красноармеец Куманин, дочь профессора Тася, бывший царский офицер Зимин и проводник Митя. Найдя золото, они тут же попадают в руки белых. А чудом спасшиеся Куманин и юный партизан Митька отправляются с документами экспедиции в Петроград&hellip;",
                    Actor01 = "Николай Гринько",
                    Actor02 = "Евгения Симонова",
                    Actor03 = "Вахтанг Кикабидзе",
                    Actor04 = "Сергей Шевкуненко",
                    Actor05 = "Александр Кайдановский",
                    Actor06 = "Николай Олялин",
                    Actor07 = "Виктор Сергачёв",
                    ContentUrl = "http://vladimirz.asuscomm.com/Video/br-ptica-1-seriya.mp4"
                },
                new MovieModel()
                {
                    MovieId = Guid.NewGuid(),
                    MovieName = "kr-zvezda",
                    ImageName = "kr-zvezda",
                    MovieCaption = "Криминальная звезда",
                    Duration = "T00H43M13S",
                    DatePublished = "2004-01-01",
                    DateCreated = "2004-01-01",
                    UploadDate = "2021-12-19",
                    IsFamilyFriendly = "true",
                    InLanguage = "ru",
                    РroductionCompany = "телеканал Россия",
                    Director = "Андрей Грачев",
                    MusicBy = "телеканал Россия",
                    Genre = "документальный",
                    Description = "Имя Сергея Шевкуненко ничего не скажет современному подростку. А ведь он сыграл главные роли в культовых фильмах своего времени «Кортик» и «Бронзовая птица». Фильм «Криминальная звезда» - о юном артисте, когда-то подававшем большие надежды, расскажет также о нескольких других трагических судьбах актеров советского кино.",
                    Actor01 = "Сергей Шевкуненко",
                    ContentUrl = "http://vladimirz.asuscomm.com/Video/kr-zvezda.mp4"
                },
                new MovieModel()
                {
                    MovieId = Guid.NewGuid(),
                    MovieName = "no-movie",
                    ImageName = "no-image",
                    MovieCaption = "Фильм не найден",
                    Duration = "T00H00M00S",
                    DatePublished = "2022-01-01",
                    DateCreated = "2022-01-01",
                    UploadDate = "2022-01-01",
                    IsFamilyFriendly = "true",
                    InLanguage = String.Empty,
                    РroductionCompany = String.Empty,
                    Director = String.Empty,
                    MusicBy = String.Empty,
                    Genre = String.Empty,
                    Description = String.Empty,
                    Actor01 = String.Empty,
                    ContentUrl = "http://vladimirz.asuscomm.com/Video/kr-zvezda.mp4"
                }
            };
        }
        public IEnumerable<MovieModel> GettAllMovies()
        {
            return _movieList;
        }
    }
}
