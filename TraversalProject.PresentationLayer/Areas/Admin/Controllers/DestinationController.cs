using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        public IActionResult CreateDestination() => View();

        [HttpPost]
        public IActionResult CreateDestination(Destination destination)
        {
            _destinationService.InsertBL(destination);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            var destinationValue = _destinationService.GetByIdBL(id);
            _destinationService.DeleteBL(destinationValue);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateDestination (int id)
        {
            var destinationValue = _destinationService.GetByIdBL(id);
            return View(destinationValue);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.UpdateBL(destination);
            return RedirectToAction("Index");
        }
}
}
