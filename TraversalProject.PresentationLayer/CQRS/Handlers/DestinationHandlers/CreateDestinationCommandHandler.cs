using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.CQRS.Commands.DestinationCommands;

namespace TraversalProject.PresentationLayer.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommands command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                DayNight = command.DayNight,
                Price = command.Price,
                Capacity = command.Capacity,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
