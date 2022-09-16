using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotations.Model
{
    public class RegistrationBindingModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Required]
        [UIHint("Password")]
        [StringLength(15, MinimumLength = 6)]
        [Compare("ConfirmPassword")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6)]
        [UIHint("Password")]
        [Display(Name = "Подтверждение пароля")]
        public string ConfirmPassword { get; set; }
    }
}
