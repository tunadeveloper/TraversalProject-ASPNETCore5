using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserComment { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
