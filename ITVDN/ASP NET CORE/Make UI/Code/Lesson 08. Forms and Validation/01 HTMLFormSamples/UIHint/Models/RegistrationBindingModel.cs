using System.ComponentModel.DataAnnotations;

namespace UIHint.Models
{
    public class RegistrationBindingModel
    {
        public string Login { get; set; }
        [UIHint("EmailAddress")]
        public string Email { get; set; }
        [UIHint("Password")]
        public string Password { get; set; }
        [UIHint("Password")]
        public string PasswordConfirm { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
