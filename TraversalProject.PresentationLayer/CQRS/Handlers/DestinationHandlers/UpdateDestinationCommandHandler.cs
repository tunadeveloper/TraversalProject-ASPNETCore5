using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.PresentationLayer.CQRS.Commands.DestinationCommands;

namespace TraversalProject.PresentationLayer.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;
            values.Capacity = command.Capacity;
            _context.SaveChanges();
        }
    }
}
