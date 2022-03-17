using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    //[Index(nameof(ImageName), IsUnique = true)]
    public class ImageModel
    {
        [Key]
        [Display(Name = "«ImageId» идентификатор Guid")]
        public Guid ImageId { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«description» для Microdata:")]
        public string ImageDescription { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«caption» для Microdata:")]
        public string ImageCaption { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://...")]
        [Display(Name = "«contentUrl» для Microdata:")]
        public Uri ImageContentUrl { get; set; }

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
        [DataType(DataType.ImageUrl, ErrorMessage = "Поле должно содержать адрес http://...")]
        [Display(Name = "«thumbnailUrl» для Microdata:")]
        public Uri ImageThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Ширина картинки от 0 до 8000 px")]
        [Display(Name = "Ширина иконки:")]
        public int ImageThumbnailWidth { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Высота картинки от 0 до 8000 px")]
        [Display(Name = "Высота иконки:")]
        public int ImageThumbnailHeight { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "«alt» и «title» для тега «img»:")]
        public string ImageAlt { get; set; }
    }
}