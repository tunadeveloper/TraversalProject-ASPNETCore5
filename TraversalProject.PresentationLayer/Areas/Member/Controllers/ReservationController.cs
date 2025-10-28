using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
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

        public async Task<IActionResult> MyActiveReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByAcceptedBL(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByPreviousBL(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByWaitApprovalBL(values.Id);
            return View(valuesList);
        }

        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.GetListBL()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 1;
            reservation.Status = "Onay Bekliyor";
            _reservationService.InsertBL(reservation);
            return RedirectToAction("MyActiveReservation");
        }
    }
}
