using System.Collections.Generic;
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
        private readonly ICommentService _commentService;

        public UserController(IAppUserService appUserService, IReservationService reservationService, ICommentService commentService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View(_appUserService.GetListBL());
        }

        public IActionResult UpdateUser(int id)
        {
            var values = _appUserService.GetByIdBL(id);
            if (values == null)
                return RedirectToAction("Index", "User", new { area = "Admin" });
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateUser(AppUser appUser)
        {
            _appUserService.UpdateBL(appUser);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetByIdBL(id);
            if (values != null)
                _appUserService.DeleteBL(values);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }

        public IActionResult CreateUser() => View();

        [HttpPost]
        public IActionResult CreateUser(AppUser appUser)
        {
            _appUserService.InsertBL(appUser);
            return RedirectToAction("Index", "User", new { area = "Admin" });
        }

        public IActionResult UserCommentDetail(int id)
        {
            var user = _appUserService.GetByIdBL(id);
            if (user == null)
                return RedirectToAction("Index", "User", new { area = "Admin" });
            var comments = _commentService.GetListByUserIdBL(id) ?? new List<Comment>();
            ViewBag.Comments = comments;
            return View(user);
        }

        public IActionResult UserReservation(int id)
        {
            var values = _reservationService.GetListWithReservationByAcceptedBL(id) ?? new List<Reservation>();
            return View(values);
        }
    }
}
