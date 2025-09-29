using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _PopularDestinationComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _PopularDestinationComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.GetListBL();
            return View(values);
        }
    }
}
