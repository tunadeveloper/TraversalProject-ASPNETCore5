using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.PresentationLayer.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetListBL();
            return View(values);
        }

        public IActionResult DestinationDetails(int id)
        {
            var values = _destinationService.GetByIdBL(id);
            return View(values);
        }
    }
}
