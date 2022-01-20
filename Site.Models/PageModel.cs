using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class PageModel
    {
        [Key]
        public Guid PageModelId { get; set; }

        public uint PageNumber { get; set; }

        public string Description { get; set; }

        public Guid ImageModelImageId { get; set; }
        public ImageModel ImageModel { get; set; }
    }
}
