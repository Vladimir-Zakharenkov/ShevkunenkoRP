using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    //[Index(nameof(ImageName), IsUnique = true)]
    public class ImageModel
    {
        [Key]
        [Display(Name = "ImageId :")]
        public Guid ImageId { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "ImageCaption :")]
        public string ImageCaption { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "ImageDescription :")]
        public string ImageDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Url, ErrorMessage = "Поле должно содержать адрес http://...")]
        [Display(Name = "ImageContentUrl :")]
        public Uri ImageContentUrl { get; set; } = new Uri("https://shevkunenko.site/images/no-image.png");

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Ширина картинки от 0 до 8000 px")]
        [Display(Name = "ImageWidth :")]
        public int ImageWidth { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Высота картинки от 0 до 8000 px")]
        [Display(Name = "ImageHeight :")]
        public int ImageHeight { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Url, ErrorMessage = "Поле должно содержать адрес http://...")]
        [Display(Name = "ImageThumbnailUrl :")]
        public Uri ImageThumbnailUrl { get; set; } = new Uri("https://shevkunenko.site/images/no-image.png");

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Ширина картинки от 0 до 8000 px")]
        [Display(Name = "ImageThumbnailWidth :")]
        public int ImageThumbnailWidth { get; set; } = 300;

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Duration, ErrorMessage = "Поле не может быть пустым")]
        [Range(0, 8000, ErrorMessage = "Высота картинки от 0 до 8000 px")]
        [Display(Name = "ImageThumbnailHeight :")]
        public int ImageThumbnailHeight { get; set; } = 300;

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "ImageAlt :")]
        public string ImageAlt { get; set; } = string.Empty;
    }
}