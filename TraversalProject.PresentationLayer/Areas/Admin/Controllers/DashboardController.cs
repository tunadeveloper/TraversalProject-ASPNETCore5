using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly INewsletterService _newsletterService;
        private readonly ICommentService _commentService;
        private readonly IGuideService _guideService;

        public DashboardController(IDestinationService destinationService, IReservationService reservationService, INewsletterService newsletterService, ICommentService commentService, IGuideService guideService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _newsletterService = newsletterService;
            _commentService = commentService;
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            ViewBag.DestinationCount = _destinationService.GetListBL().Count;
            ViewBag.ReservationCount = _reservationService.GetListBL().Count;
            ViewBag.NewsletterCount = _newsletterService.GetListBL().Count;
            ViewBag.CommentCount = _commentService.GetListBL().Count;
            var values = _guideService.GetListBL().Take(3).ToList();
            return View(values);
        }
    }
}
