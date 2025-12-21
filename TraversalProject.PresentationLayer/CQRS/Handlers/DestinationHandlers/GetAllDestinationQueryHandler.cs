using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.PresentationLayer.CQRS.Queries.DestinationQueries;
using TraversalProject.PresentationLayer.CQRS.Results.DestinationResults;

namespace TraversalProject.PresentationLayer.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x=>new GetAllDestinationQueryResult
            {
                Id = x.DestinationId,
                City = x.City,
                DayNight = x.DayNight,
                Price = x.Price,
                Capacity = x.Capacity
            }).AsNoTracking().ToList();;

            return values;
        }
    }
}
