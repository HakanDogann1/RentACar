using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.EntityLayer.Concrete;
using RentACar.PresentetionLayer.Models;
using System.Threading.Tasks;

namespace RentACar.PresentetionLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.EMail,
                City = model.City,
                Age = model.Age,
                UserName = model.UserName,
            };
            var values = await _userManager.CreateAsync(appUser,model.Password);
            if(values.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }
            else
            {
                foreach(var item in values.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
