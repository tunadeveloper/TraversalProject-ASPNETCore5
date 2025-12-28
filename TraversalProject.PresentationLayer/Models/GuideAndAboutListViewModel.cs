using System.Collections.Generic;

namespace TraversalProject.PresentationLayer.Models
{
    public class GuideAndAboutListViewModel
    {
        public List<TraversalProject.EntityLayer.Concrete.Guide> Guides { get; set; }
        public List<TraversalProject.EntityLayer.Concrete.About> Abouts { get; set; }
    }
}
