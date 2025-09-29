﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
