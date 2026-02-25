using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Areas.Admin.Models;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole([Bind(Prefix = "")] AppRole model, [FromForm] string Name = null)
        {
            var roleName = (Name ?? model?.Name)?.Trim();
            if (string.IsNullOrWhiteSpace(roleName))
            {
                ModelState.AddModelError("Name", "Rol adı gereklidir.");
                return View(model ?? new AppRole());
            }
            var result = await _roleManager.CreateAsync(new AppRole { Name = roleName });
            if (result.Succeeded)
                return RedirectToAction("Index", "Role", new { area = "Admin" });
            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);
            if (model == null) model = new AppRole();
            model.Name = roleName;
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

        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return RedirectToAction("UserList");
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            var roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var role in roles)
            {
                roleAssignViewModels.Add(new RoleAssignViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    RoleExist = userRoles.Contains(role.Name)
                });
            }
            ViewBag.UserId = id;
            ViewBag.NameSurname = user.NameSurname ?? user.UserName ?? user.Email ?? "Kullanıcı";
            return View(roleAssignViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(int id, int[] roleIds)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return RedirectToAction("UserList");
            var currentRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, currentRoles);
            if (roleIds != null && roleIds.Length > 0)
            {
                var roleNames = _roleManager.Roles.Where(r => roleIds.Contains(r.Id)).Select(r => r.Name).ToArray();
                await _userManager.AddToRolesAsync(user, roleNames);
            }
            return RedirectToAction("UserList");
        }
    }
}
