using System.ComponentModel.DataAnnotations;

namespace TraversalProject.PresentationLayer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresini giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre giriniz")]
        public string Password { get; set; }
    }
}
