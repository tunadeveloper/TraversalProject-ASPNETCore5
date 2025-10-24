using Microsoft.AspNetCore.Http;

namespace TraversalProject.PresentationLayer.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string nameSurname { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string imageUrl { get; set; }
        public IFormFile image { get; set; }
    }
}
