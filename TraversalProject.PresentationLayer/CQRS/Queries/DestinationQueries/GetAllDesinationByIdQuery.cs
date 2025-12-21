namespace TraversalProject.PresentationLayer.CQRS.Queries.DestinationQueries
{
    public class GetAllDesinationByIdQuery
    {
        public int Id { get; set; }

        public GetAllDesinationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
