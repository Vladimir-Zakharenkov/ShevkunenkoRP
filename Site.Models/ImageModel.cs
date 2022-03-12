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
        [Display(Name = "«image-name»:")]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«name» для Microdata:")]
        public string ImageName2 { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«description» для Microdata:")]
        public string ImageDescription { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«caption» для Microdata:")]
        public string ImageCaption { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://....")]
        [Display(Name = "«contentUrl» для Microdata:")]
        public string ImageContentUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://....")]
        [Display(Name = "«thumbnailUrl» для Microdata:")]
        public string ImageThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Ширина картинки от 0 до 8000 px")]
        [Display(Name = "Ширина картинки:")]
        public int ImageWidth { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Высота картинки от 0 до 8000 px")]
        [Display(Name = "Высота картинки:")]
        public int ImageHeight { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Адрес картинки для вьюшек:")]
        public string ImageSrc { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«alt» для тега «img»:")]
        public string ImageAlt { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«title» для тега «img»:")]
        public string ImageTitle { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Тип изображения:")]
        public string ImageType { get; set; }
    }
}