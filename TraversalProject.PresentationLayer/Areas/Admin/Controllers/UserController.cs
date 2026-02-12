using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
     private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            return View(_appUserService.GetListBL());
        }

        public IActionResult UpdateUser(int id)
        {
            var values = _appUserService.GetByIdBL(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateUser(AppUser appUser)
        {
            _appUserService.UpdateBL(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetByIdBL(id);
            _appUserService.DeleteBL(values);
            return RedirectToAction("Index");
        }

        public IActionResult CreateUser() => View();

        [HttpPost]
        public IActionResult CreateUser(AppUser appUser)
        {
            _appUserService.InsertBL(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult UserCommentDetail(int id)
        {
            var values = _appUserService.GetByIdBL(id);
            return View(values);
        }

        public IActionResult UserReservation(int id)
        {
           var values = _reservationService.GetListWithReservationByAcceptedBL(id);
            return View(values);
        }
    }
}
