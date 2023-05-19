using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.EntityLayer.Concrete;
using RentACar.PresentetionLayer.Models;
using System.Threading.Tasks;

namespace RentACar.PresentetionLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(LoginViewModel model)
        {

            var values =await _signInManager.PasswordSignInAsync(model.UserName,model.Password,false,false);
            if (values.Succeeded)
            {
                return RedirectToAction("Index","AboutUs");
            }
            return View();
        }
    }
}
