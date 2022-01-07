using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class ImageModel
    {
        [Key]
        public Guid ImageId { get; set; }

        //For viewcomponent
        public string ImageName { get; set; }

        //For microdata
        public string ImageName2 { get; set; }

        public string ImageDescription { get; set; }

        public string ImageCaption { get; set; }

        public string ImageContentUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public int ImageWidth { get; set; }

        public int ImageHeight { get; set; }

        public string ImageSrc { get; set; }

        public string ImageAlt { get; set; }

        public string ImageTitle { get; set; }
    }
}