using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.ViewComponents.MemberDashboard
{
    public class _PlatformSettingComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IReservationService _reservationService;

        public _PlatformSettingComponentPartial(UserManager<AppUser> userManager, IReservationService reservationService)
        {
            _userManager = userManager;
            _reservationService = reservationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                ViewBag.Toplam = 0;
                ViewBag.OnayBekleyen = 0;
                ViewBag.Onaylanan = 0;
                ViewBag.Gecmis = 0;
                return View();
            }

            var id = user.Id;
            ViewBag.OnayBekleyen = _reservationService.GetListWithReservationByWaitApprovalBL(id).Count;
            ViewBag.Onaylanan = _reservationService.GetListWithReservationByAcceptedBL(id).Count;
            ViewBag.Gecmis = _reservationService.GetListWithReservationByPreviousBL(id).Count;
            ViewBag.Toplam = (int)ViewBag.OnayBekleyen + (int)ViewBag.Onaylanan + (int)ViewBag.Gecmis;
            return View();
        }
    }
}
