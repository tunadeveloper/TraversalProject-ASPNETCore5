using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.PresentationLayer.CQRS.Queries.GuideQueries;
using TraversalProject.PresentationLayer.CQRS.Results.GuideResults;

namespace TraversalProject.PresentationLayer.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {

        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides
                 .Select(x => new GetAllGuideQueryResult
                 {
                     GuideId = x.GuideId,
                     NameSurname = x.NameSurname,
                     Description = x.Description,
                     ImageUrl = x.ImageUrl
                 }).AsNoTracking().ToListAsync();
        }
    }
}
