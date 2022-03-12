using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    [Index(nameof(PageNumber), IsUnique = true)]
    public class SitemapModel
    {
        [Key]
        public Guid SitemapModelId { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration)]
        [Display(Name = "Уникальный номер страницы")]
        public uint PageNumber { get; set; }

        [Required(ErrorMessage = "Необходимо ввести адрес страницы")]
        [DataType(DataType.Url)]
        [Display(Name = "Адрес страницы:")]
        public Uri Loc { get; set; }

        [Required(ErrorMessage = "Необходимо указать дату")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата изменения:")]
        public DateTime Lastmod { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Частота изменения:")]
        [MaxLength(7)]
        public string Changefreq { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration)]
        [Display(Name = "Приоритет страницы:")]
        [MaxLength(3)]
        public string Priority { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Фон страницы слева:")]
        public string LeftBackground { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Фон страницы справа:")]
        public string RightBackground { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Заголовок страницы:")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Описание страницы:")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Ключевые слова:")]
        public string KeyWords { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Картинка для страницы (GUID):")]
        public Guid ImageModelImageId { get; set; }
        public ImageModel ImageModel { get; set; }
    }
}