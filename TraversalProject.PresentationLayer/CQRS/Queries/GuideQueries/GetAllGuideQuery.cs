using MediatR;
using System.Collections.Generic;
using TraversalProject.PresentationLayer.CQRS.Results.GuideResults;

namespace TraversalProject.PresentationLayer.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
