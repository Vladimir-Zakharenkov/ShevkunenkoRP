using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class ImageModel
    {
        [Key]
        [ValidateNever]
        public Guid ImageId { get; set; }

        //For viewcomponent
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Имя для View Component")]
        public string ImageName { get; set; }

        //For microdata
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Имя для microdata")]
        public string ImageName2 { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Описание картинки")]
        public string ImageDescription { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Подпись к картинке")]
        public string ImageCaption { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://....")]
        [Display(Name = "Адрес картинки")]
        public string ImageContentUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://....")]
        [Display(Name = "Адрес иконки картинки")]
        public string ImageThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Ширина картинки от 0 до 8000 px")]
        [Display(Name = "Ширина картинки в px")]
        public int ImageWidth { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Высота картинки от 0 до 8000 px")]
        [Display(Name = "Высота картинки в px")]
        public int ImageHeight { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        public string ImageSrc { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Текст для атрибута alt")]
        public string ImageAlt { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Текст для атрибута title")]
        public string ImageTitle { get; set; }
    }
}