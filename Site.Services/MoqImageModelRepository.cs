using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    ImagelUrl = "https://shevkunenko.site/images/cards/main-page.png",
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
                    ImagelUrl = "https://shevkunenko.site/images/cards/biografy-page.png",
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
                    ImagelUrl = "https://shevkunenko.site/images/cards/films-page.png",
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
                    ImagelUrl = "https://shevkunenko.site/images/cards/pressa-page.png",
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
                    ImagelUrl = "https://shevkunenko.site/images/cards/foto-page.png",
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
                    ImagelUrl = "https://shevkunenko.site/images/cards/gostevaya-page.png",
                    ImageWidth = 720,
                    ImageHeight = 540,
                    ImageSrc = "/images/cards/gostevaya-page.png",
                    ImageAlt = "Гостевая книга сайта",
                    ImageTitle = "Гостевая книга сайта"
                }
            };
        }
        public IEnumerable<ImageModel> GetAllImages()
        {
            return _imageList;
        }
    }
}
