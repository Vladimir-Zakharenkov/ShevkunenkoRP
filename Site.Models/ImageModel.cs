using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class ImageModel
    {
        [Key]
        public Guid ImageId { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string ImageCaption { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageContentUrl { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageThumbnailUrl { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImagelUrl { get; set; }

        [Required]
        public int ImageWidth { get; set; }

        [Required]
        public int ImageHeight { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageSrc { get; set; }

        [Required]
        public string ImageAlt { get; set; }

        [Required]
        public string ImageTitle { get; set; }
    }
}
