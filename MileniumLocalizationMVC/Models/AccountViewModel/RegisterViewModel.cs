using System.ComponentModel.DataAnnotations;

namespace MileniumLocalizationMVC.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress(ErrorMessage = "emailInvalid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "nicknameLength", MinimumLength = 30)]
        [Display(Name = "Nickname")]
        public string Nickname { get; set; }
    }
}
