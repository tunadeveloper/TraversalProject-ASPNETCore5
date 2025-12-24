using MediatR;

namespace TraversalProject.PresentationLayer.CQRS.Commands.GuideCommands
{
    public class UpdateGuideCommand:IRequest
    {
        public int GuideId { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string XUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
