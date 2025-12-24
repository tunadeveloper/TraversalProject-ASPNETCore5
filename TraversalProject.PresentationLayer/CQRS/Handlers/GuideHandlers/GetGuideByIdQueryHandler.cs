using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.PresentationLayer.CQRS.Queries.GuideQueries;
using TraversalProject.PresentationLayer.CQRS.Results.GuideResults;

namespace TraversalProject.PresentationLayer.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuidebyIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuidebyIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideId,
                NameSurname = values.NameSurname,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                XUrl = values.XUrl,
                InstagramUrl = values.InstagramUrl
            };
        }
    }
}
