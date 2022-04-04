using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class MovieModel
    {
        [Key]
        public Guid MovieId { get; set; }

        [Required(ErrorMessage = "Введите название фильма")]
        [DataType(DataType.Text)]
        public string MovieCaption { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Time)]
        public DateTime Duration { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        public string ScreenFormat { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Date)]
        public DateTime DatePublished { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Нет ограничений по возрасту:")]
        public bool IsFamilyFriendly { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        public string InLanguage { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        public string РroductionCompany { get; set; }

        [DataType(DataType.Text)]
        public string Director { get; set; }

        [DataType(DataType.Text)]
        public string MusicBy { get; set; }

        [Required(ErrorMessage = "Введите жанр фильма")]
        [DataType(DataType.Text)]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Краткое содержание (HTML):")]
        public string Description { get; set; }

        //[Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Краткое содержание:")]
        public string DescriptionForSchemaOrg { get; set; }

        [DataType(DataType.Text)]
        public string Actor01 { get; set; }

        [DataType(DataType.Text)]
        public string Actor02 { get; set; }

        [DataType(DataType.Text)]
        public string Actor03 { get; set; }

        [DataType(DataType.Text)]
        public string Actor04 { get; set; }

        [DataType(DataType.Text)]
        public string Actor05 { get; set; }

        [DataType(DataType.Text)]
        public string Actor06 { get; set; }

        [DataType(DataType.Text)]
        public string Actor07 { get; set; }

        [DataType(DataType.Text)]
        public string Actor08 { get; set; }

        [DataType(DataType.Text)]
        public string Actor09 { get; set; }

        [DataType(DataType.Text)]
        public string Actor10 { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Url)]
        public Uri ContentUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        public string CaptionForOnline { get; set; }

        [DataType(DataType.Text)]
        public string YouTube { get; set; }

        [DataType(DataType.Text)]
        public string VkVideo { get; set; }

        [DataType(DataType.Text)]
        public string MailRuVideo { get; set; }

        [DataType(DataType.Text)]
        public string OkVideo { get; set; }

        [DataType(DataType.Text)]
        public string YandexDiskVideo { get; set; }

        [DataType(DataType.Text)]
        public string KinoTeatrRu { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        public string AspPage { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        public Guid ImageModelImageId { get; set; }
        public ImageModel ImageModel { get; set; }
    }
}