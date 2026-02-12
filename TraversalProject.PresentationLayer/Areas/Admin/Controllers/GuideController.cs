
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.ValidationRules;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.GetListBL();
            return View(values);
        }

        public IActionResult CreateGuide() => View();

        [HttpPost]
        public IActionResult CreateGuide(EntityLayer.Concrete.Guide guide)
        {
            GuideValidator _guideValidator = new GuideValidator();
            ValidationResult result = _guideValidator.Validate(guide);
            if (result.IsValid)
            {
                guide.Status = true;
                _guideService.InsertBL(guide);
                return Redirect("/Admin/Guide/Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult DeleteGuide(int id)
        {
            var guideValue = _guideService.GetByIdBL(id);
            _guideService.DeleteBL(guideValue);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateGuide(int id)
        {
            var guideValue = _guideService.GetByIdBL(id);
            return View(guideValue);
        }
        [HttpPost]
        public IActionResult UpdateGuide(EntityLayer.Concrete.Guide guide)
        {
            _guideService.UpdateBL(guide);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            var guide = _guideService.GetByIdBL(id);
            guide.Status = true;
            _guideService.UpdateBL(guide);
            return Redirect("/Admin/Guide/Index");
        }

        public IActionResult ChangeToFalse(int id)
        {
            var guide = _guideService.GetByIdBL(id);
            guide.Status = false;
            _guideService.UpdateBL(guide);
            return Redirect("/Admin/Guide/Index");
        }

    }
}
