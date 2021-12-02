using System;
using System.ComponentModel.DataAnnotations;

namespace Pages.Models
{
    public class CardModel
    {
        [Key]
        public Guid CardId { get; set; } = System.Guid.NewGuid();

        [Required]
        [DataType(DataType.Url)]
        public string CardLink { get; set; } = "https://shevkunenko.ru/biografy.htm";

        [Required]
        public string ImageCaption { get; set; } = "Биография Сергея Юрьевича Шевкуненко";

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageContentUrl { get; set; } = "https://shevkunenko.site/images/cards/biografy-page.png";
        
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageThumbnailUrl { get; set; } = "https://shevkunenko.site/images/cards/biografy-page.png";
        
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImagelUrl { get; set; } = "https://shevkunenko.site/images/cards/biografy-page.png";
        
        [Required]
        public int ImageWidth { get; set; } = 720;
        
        [Required]
        public int ImageHeight { get; set; } = 540;
        
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageSrc { get; set; } = "/images/cards/biografy-page.png";
        
        [Required]
        public string ImageAlt { get; set; } = "Биография Сергея Юрьевича Шевкуненко";
        
        [Required]
        public string ImageTitle { get; set; } = "Биография Сергея Юрьевича Шевкуненко";
        
        [Required]
        public bool CardBody { get; set; } = true;
        
        [Required]
        public string CardText { get; set; } = "БИОГРАФИЯ";
    }
}
