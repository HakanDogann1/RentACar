using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.EntityLayer.Concrete;
using RentACar.PresentetionLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.PresentetionLayer.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public RoleAssignController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values=_userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> UserRoleAssign(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRole = await _userManager.GetRolesAsync(user);
            List<UserRoleAssignViewModel> userRoleAssignViewModels = new List<UserRoleAssignViewModel>();
            foreach (var item in roles)
            {
                UserRoleAssignViewModel model = new UserRoleAssignViewModel();
                model.RoleID = item.Id;
                model.RoleName=item.Name;
                model.RoleExist =userRole.Contains(item.Name);
                userRoleAssignViewModels.Add(model);
            }
            return View(userRoleAssignViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> UserRoleAssign(List<UserRoleAssignViewModel> models)
        {
            var userid = (int)TempData["userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach( var item in models)
            {
                if(item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("Index");

        }
    }
}
