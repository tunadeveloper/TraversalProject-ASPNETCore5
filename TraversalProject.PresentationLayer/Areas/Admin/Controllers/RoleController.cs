using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View(new AppRole());
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(AppRole model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model?.Name))
            {
                ModelState.AddModelError("Name", "Rol adı gereklidir.");
                return View(model ?? new AppRole());
            }
            var result = await _roleManager.CreateAsync(new AppRole { Name = model.Name.Trim() });
            if (result.Succeeded)
                return RedirectToAction("Index");
            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateRole(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null)
                return RedirectToAction("Index");
            return View(role);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(int id, string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                ModelState.AddModelError("Name", "Rol adı gereklidir.");
                return View(new AppRole { Id = id, Name = Name });
            }
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null)
                return RedirectToAction("Index");
            role.Name = Name.Trim();
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
                return RedirectToAction("Index");
            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);
            return View(new AppRole { Id = id, Name = Name });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role != null)
                await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }
    }
}
