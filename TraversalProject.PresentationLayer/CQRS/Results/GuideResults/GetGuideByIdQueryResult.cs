namespace TraversalProject.PresentationLayer.CQRS.Results.GuideResults
{
    public class GetGuideByIdQueryResult
    {
        public int GuideId { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string XUrl { get; set; }
        public string InstagramUrl { get; set; }
    }
}
