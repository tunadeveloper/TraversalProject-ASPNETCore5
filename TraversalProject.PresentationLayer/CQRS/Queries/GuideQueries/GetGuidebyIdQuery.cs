using MediatR;
using TraversalProject.PresentationLayer.CQRS.Results.GuideResults;

namespace TraversalProject.PresentationLayer.CQRS.Queries.GuideQueries
{
    public class GetGuidebyIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGuidebyIdQuery(int id)
        {
            Id = id;
        }
    }
}
