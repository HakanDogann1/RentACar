using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
