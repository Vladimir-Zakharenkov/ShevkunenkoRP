using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExplicitValidation.Model
{
    public class RegistrationBindingModel
    {
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        
        public string Email { get; set; }
        
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [UIHint("Password")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [UIHint("Password")]
        [Display(Name = "Подтверждение пароля")]
        public string ConfirmPassword { get; set; }
    }
}
