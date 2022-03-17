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
        [Display(Name = "параметр «image-name» для ViewComponent")]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Адрес страницы")]
        public Uri CardLink { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Наличие текста под картинкой")]
        public bool CardBody { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Текст под картинкой")]
        public string CardText { get; set; }

        [Display(Name = "Карточка для фильма")]
        public bool CardMovie { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Название фильма")]
        public string MovieCaption { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DataType(DataType.Text)]
        [Display(Name = "Картинка для карточки (GUID):")]
        public Guid ImageModelImageId { get; set; }
        public ImageModel ImageModel { get; set; }
    }
}