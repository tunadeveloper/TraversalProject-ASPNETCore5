using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.DTOLayer.DTOs.AppUserDTOs
{
    public class AppUserRegisterDTO
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
