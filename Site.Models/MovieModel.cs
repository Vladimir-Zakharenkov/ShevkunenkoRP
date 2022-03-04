using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class MovieModel
    {
        [Key]
        public Guid MovieId { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "параметр «image-name» для ViewComponent")]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Название фильма")]
        public string MovieCaption { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Time)]
        [Display(Name = "Продолжительность фильма")]
        public DateTime Duration { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата примьеры")]
        public DateTime DatePublished { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата производства")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата публикации на сайте")]
        public DateTime UploadDate { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Нет ограничений для просмотра")]
        public bool IsFamilyFriendly { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Язык звуковой дорожки")]
        public string InLanguage { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Название киностудии")]
        public string РroductionCompany { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Режиссер")]
        public string Director { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Композитор")]
        public string MusicBy { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Жанр фильма")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Краткое содержание")]
        public string Description { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor01 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor02 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor03 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor04 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor05 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor06 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor07 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor08 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor09 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Актер")]
        public string Actor10 { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Url)]
        [Display(Name = "Адрес в Интернете")]
        public string ContentUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Заголовок страницы воспроизведения")]
        public string CaptionForOnline { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Видео на youtube.com")]
        public string YouTube { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Видео на vk.com")]
        public string VkVideo { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Видео на mail.ru")]
        public string MailRuVideo { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Видео на ok.ru")]
        public string OkVideo { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Видео на YandexDisk")]
        public string YandexDiskVideo { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Информация на kino-teatr.ru")]
        public string KinoTeatrRu { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Адрес страницы на сайте")]
        public string AspPage { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Картинка для фильма")]
        public string Thumbnail { get; set; }
    }
}