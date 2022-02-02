using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class CardModel
    {
        [Key]
        public Guid CardId { get; set; }

        [Required]
        public string CardName { get; set; }

        public string? CardLink { get; set; }

        [Required]
        public bool CardBody { get; set; }

        public string? CardText { get; set; }

        public bool CardMovie { get; set; }

        public string? MovieName { get; set; }

        public Guid ImageModelImageId { get; set; }
        public ImageModel ImageModel { get; set; }

    }
}