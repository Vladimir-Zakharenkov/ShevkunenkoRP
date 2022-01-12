using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Services
{
    public class MoqImageModelRepository : IImageModelRepository
    {
        private List<ImageModel> _imageList;

        public MoqImageModelRepository()
        {
            _imageList = new()
            {
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "main-page",
                    ImageCaption = "Сайт, посвященный Сергею Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/main-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/main-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/main-page.png",
                    ImageAlt = "Сайт, посвященный Сергею Шевкуненко",
                    ImageTitle = "Сайт, посвященный Сергею Шевкуненко"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "biografy-page",
                    ImageCaption = "Биография Сергея Юрьевича Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/biografy-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/biografy-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/biografy-page.png",
                    ImageAlt = "Биография Сергея Юрьевича Шевкуненко",
                    ImageTitle = "Биография Сергея Юрьевича Шевкуненко"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "films-page",
                    ImageCaption = "Фильмы с участием Сергея Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/films-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/films-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/films-page.png",
                    ImageAlt = "Фильмы с участием Сергея Шевкуненко",
                    ImageTitle = "Фильмы с участием Сергея Шевкуненко"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "pressa-page",
                    ImageCaption = "Книги и статьи о Сергее Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/pressa-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/pressa-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/pressa-page.png",
                    ImageAlt = "Книги и статьи о Сергее Шевкуненко",
                    ImageTitle = "Книги и статьи о Сергее Шевкуненко"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "foto-page",
                    ImageCaption = "Фотографии Сергея Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/foto-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/foto-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/foto-page.png",
                    ImageAlt = "Фотографии Сергея Шевкуненко",
                    ImageTitle = "Фотографии Сергея Шевкуненко"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "gostevaya-page",
                    ImageCaption = "Гостевая книга сайта",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/gostevaya-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/gostevaya-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/gostevaya-page.png",
                    ImageAlt = "Гостевая книга сайта",
                    ImageTitle = "Гостевая книга сайта"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "kortik",
                    ImageCaption = "Фильм «Кортик»",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/kortik-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/kortik-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/kortik-page.png",
                    ImageAlt = "Фильм «Кортик»",
                    ImageTitle = "Фильм «Кортик»"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "br-ptica",
                    ImageCaption = "Фильм Бронзовая птица",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/bronzptica-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/bronzptica-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/bronzptica-page.png",
                    ImageAlt = "Фильм Бронзовая птица",
                    ImageTitle = "Фильм Бронзовая птица"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "pr-expediciya",
                    ImageCaption = "Фильм Пропавшая экспедиция",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/propexpediciya-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/propexpediciya-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/propexpediciya-page.png",
                    ImageAlt = "Фильм Пропавшая экспедиция",
                    ImageTitle = "Фильм Пропавшая экспедиция"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "kr-zvezda",
                    ImageCaption = "Фильм Криминальная звезда",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/krimzvezda-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/krimzvezda-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/krimzvezda-page.png",
                    ImageAlt = "Фильм Криминальная звезда",
                    ImageTitle = "Фильм Криминальная звезда"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "programs",
                    ImageCaption = "Фильмы и программы о Сергее Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/programs-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/programs-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/programs-page.png",
                    ImageAlt = "Фильмы и программы о Сергее Шевкуненко",
                    ImageTitle = "Фильмы и программы о Сергее Шевкуненко"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "znakomye",
                    ImageCaption = "Интервью из фильмов о Сергее Шевкуненко",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/people-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/people-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/people-page.png",
                    ImageAlt = "Интервью из фильмов о Сергее Шевкуненко",
                    ImageTitle = "Интервью из фильмов о Сергее Шевкуненко"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "raznoe",
                    ImageCaption = "Разное...",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/raznoe-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/raznoe-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/raznoe-page.png",
                    ImageAlt = "Разное...",
                    ImageTitle = "Разное..."
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "kalinin",
                    ImageCaption = "Калинин Николай Артемьевич",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/kalinin-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/kalinin-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/kalinin-page.png",
                    ImageAlt = "Калинин Николай Артемьевич",
                    ImageTitle = "Калинин Николай Артемьевич"
                },
                new ImageModel()
                {
                    ImageId = Guid.NewGuid(),
                    ImageName = "rybakov",
                    ImageCaption = "Рыбаков Анатолий Наумович",
                    ImageContentUrl = "https://shevkunenko.site/images/cards/pybakov-page.png",
                    ImageThumbnailUrl = "https://shevkunenko.site/images/cards/pybakov-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/pybakov-page.png",
                    ImageAlt = "Рыбаков Анатолий Наумович",
                    ImageTitle = "Рыбаков Анатолий Наумович"
                }
            };
        }

        public IEnumerable<ImageModel> Images => _imageList;

        public void AddImage(ImageModel image)
        {
            throw new NotImplementedException();
        }

        public ImageModel GetImage(Guid imageId)
        {
            throw new NotImplementedException();
        }

        public void UpdateImage(ImageModel image)
        {
            throw new NotImplementedException();
        }
    }
}
