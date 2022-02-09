using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    [Index(nameof(ImageName), IsUnique = true)]
    public class ImageModel
    {
        [Key]
        public Guid ImageId { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "параметр «image-name» для ViewComponent")]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "параметр «name» для Microdata")]
        public string ImageName2 { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "параметр «description» для Microdata")]
        public string ImageDescription { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "параметр «caption» для Microdata")]
        public string ImageCaption { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://....")]
        [Display(Name = "параметр «contentUrl» для Microdata")]
        public string ImageContentUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://....")]
        [Display(Name = "параметр «thumbnailUrl» для Microdata")]
        public string ImageThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Ширина картинки от 0 до 8000 px")]
        [Display(Name = "ширина картинки в px")]
        public int ImageWidth { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Высота картинки от 0 до 8000 px")]
        [Display(Name = "высота картинки в px")]
        public int ImageHeight { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "адрес картинки для вьюшек")]
        public string ImageSrc { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "параметр «alt» для тега «img»")]
        public string ImageAlt { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "параметр «title» для тега «img»")]
        public string ImageTitle { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "тип изображения (расширение файла)")]
        public string ImageType { get; set; }
    }
}