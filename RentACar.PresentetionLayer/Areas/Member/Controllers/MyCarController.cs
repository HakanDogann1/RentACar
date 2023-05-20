using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System.Threading.Tasks;

namespace RentACar.PresentetionLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[action]")]
    public class MyCarController : Controller
    {
        private readonly ICarRegisterService _carRegisterService;
        private readonly UserManager<AppUser> _userManager;

        public MyCarController(ICarRegisterService carRegisterService, UserManager<AppUser> userManager = null)
        {
            _carRegisterService = carRegisterService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(AppUser appUser)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var values2 = _carRegisterService.TGetCarRegisterWithCarByUser(values.Id);
            return View(values2);
        }

    }
}
