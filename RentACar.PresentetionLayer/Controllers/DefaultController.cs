using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IReserveService _reserveService;

        public DefaultController(IReserveService reserveService)
        {
            _reserveService = reserveService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult ReservePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult ReservePartial(Reserve reserve)
        {
            _reserveService.TInsert(reserve);
            return RedirectToAction("Index");
        }
    }
}
