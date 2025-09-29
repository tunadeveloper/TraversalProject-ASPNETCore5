using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.EntityLayer.Concrete
{
    public class Guide
    {
        public int GuideId { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string XUrl { get; set; }
        public string InstagramUrl { get; set; }
        public bool Status { get; set; }
    }
}
