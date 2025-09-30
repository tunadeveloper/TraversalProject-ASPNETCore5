using PagedList.Core;
using System.Collections.Generic;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Models
{
    public class CommentAndDestinationList
    {
        public IPagedList<Comment> Comments { get; set; }
        public Destination Destination { get; set; }

        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
    }
}
