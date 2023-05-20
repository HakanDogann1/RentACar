using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.Controllers
{
    public class DashminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
