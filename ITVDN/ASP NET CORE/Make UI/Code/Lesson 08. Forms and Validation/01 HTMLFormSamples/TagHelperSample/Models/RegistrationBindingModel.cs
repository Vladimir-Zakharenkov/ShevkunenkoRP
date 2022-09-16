namespace TagHelper.Models
{
    public class RegistrationBindingModel
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
