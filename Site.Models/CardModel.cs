using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class CardModel
    {
        [Key]
        public Guid CardId { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Имя карточки")]
        public string CardName { get; set; }

        [Required(ErrorMessage = "Необходимо ввести адрес страницы")]
        [DataType(DataType.Url)]
        [Display(Name = "Адрес страницы")]
        public Uri CardLink { get; set; }

        [Required]
        public bool CardBody { get; set; }

        public string? CardText { get; set; }

        public bool CardMovie { get; set; }

        public string? MovieName { get; set; }

        public Guid ImageModelImageId { get; set; }
        public ImageModel ImageModel { get; set; }

    }
}