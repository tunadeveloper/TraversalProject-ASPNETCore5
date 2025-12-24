using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.PresentationLayer.CQRS.Queries.DestinationQueries;
using TraversalProject.PresentationLayer.CQRS.Results.DestinationResults;

namespace TraversalProject.PresentationLayer.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDesinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetAllDesinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetAllDesinationByIdQueryResult Handle(GetAllDesinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetAllDesinationByIdQueryResult
            {
                Id = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight,
                Capacity = values.Capacity,
                Price = values.Price
            };
        }
    }
}
