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

        public string ImageName { get; set; } = String.Empty;

        public string MovieName { get; set; } = String.Empty;

        [Required]
        [DataType(DataType.Url)]
        public string CardLink { get; set; }

        [Required]
        public bool CardLinkHttp { get; set; }

        [Required]
        public bool CardBody { get; set; }

        [Required]
        public string CardText { get; set; }
    }
}
