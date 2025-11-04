using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.DTOLayer.DTOs.MailDTOs
{
    public class MailRequestDTO
    {
        public string NameSurname { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
