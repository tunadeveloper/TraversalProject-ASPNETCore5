using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public DestinationCqrsController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, GetAllDesinationByIdQueryHandler getAllDesinationByIdQueryHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            _getAllDesinationByIdQueryHandler = getAllDesinationByIdQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetDestination(int id)
        {
            var values = _getAllDesinationByIdQueryHandler.Handle(new GetAllDesinationByIdQuery { Id = id });
            return View(values);
        }
}
}
