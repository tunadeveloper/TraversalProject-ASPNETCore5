using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("SignUp", "Login", new {area = "Admin"});

            var destinations = _destinationService.GetListBL()
                .Where(x => x.Status)
                .ToList();

            ViewBag.Destinations = new SelectList(destinations, "DestinationId", "City");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Reservation reservation)
        {
            var destinations = _destinationService.GetListBL()
                .Where(x => x.Status)
                .ToList();
            ViewBag.Destinations = new SelectList(destinations, "DestinationId", "City");

            if (reservation.DestinationID == 0 ||
                string.IsNullOrWhiteSpace(reservation.PersonCount) ||
                reservation.ReservationDate == default)
            {
                ModelState.AddModelError("", "Rota, kişi sayısı ve tarih alanları zorunludur.");
                return View(reservation);
            }

            var userId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(userId))
            {
                ModelState.AddModelError("", "Rezervasyon yapabilmek için giriş yapmanız gerekiyor.");
                return View(reservation);
            }

            reservation.AppUserId = int.Parse(userId);
            reservation.Status = "Onay Bekliyor";

            _reservationService.InsertBL(reservation);

            TempData["ReservationSuccess"] =
                "Rezervasyonunuz alındı. En kısa sürede onay süreciniz başlayacaktır.";

            return RedirectToAction("Index");
        }
    }
}
