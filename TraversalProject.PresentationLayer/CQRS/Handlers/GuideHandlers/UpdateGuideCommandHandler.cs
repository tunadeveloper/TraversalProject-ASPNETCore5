using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.PresentationLayer.CQRS.Commands.GuideCommands;

namespace TraversalProject.PresentationLayer.CQRS.Handlers.GuideHandlers
{
    public class UpdateGuideCommandHandler : IRequestHandler<UpdateGuideCommand>
    {
        private readonly Context _context;

        public UpdateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateGuideCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.GuideId);
            values.NameSurname = request.NameSurname;
            values.Description = request.Description;
            values.ImageUrl = request.ImageUrl;
            values.XUrl = request.XUrl;
            values.InstagramUrl = request.InstagramUrl;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
