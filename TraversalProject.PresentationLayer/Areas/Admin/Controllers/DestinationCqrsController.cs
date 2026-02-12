using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.PresentationLayer.CQRS.Commands.DestinationCommands;
using TraversalProject.PresentationLayer.CQRS.Handlers.DestinationHandlers;
using TraversalProject.PresentationLayer.CQRS.Queries.DestinationQueries;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCqrsController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        private readonly GetAllDesinationByIdQueryHandler _getAllDesinationByIdQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        public DestinationCqrsController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, GetAllDesinationByIdQueryHandler getAllDesinationByIdQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            _getAllDesinationByIdQueryHandler = getAllDesinationByIdQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetDestination(int id)
        {
            var values = _getAllDesinationByIdQueryHandler.Handle(new GetAllDesinationByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
            return Redirect("/Admin/DestinationCqrs/Index");
        }
        public IActionResult CreateDestination() => View();

        [HttpPost]
        public IActionResult CreateDestination(TraversalProject.PresentationLayer.CQRS.Commands.DestinationCommands.CreateDestinationCommands command)
        {
            if (ModelState.IsValid)
            {
                _createDestinationCommandHandler.Handle(command);
                return Redirect("/Admin/DestinationCqrs/Index");
            }
            return View();

        }

        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return Redirect("/Admin/DestinationCqrs/Index");
        }
    }
}
