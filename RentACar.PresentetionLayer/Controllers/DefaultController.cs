using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IReserveService _reserveService;
        private readonly ICarService _carService;

		public DefaultController(IReserveService reserveService, ICarService carService)
		{
			_reserveService = reserveService;
			_carService = carService;
		}

		public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
        public IActionResult CarList()
        {
            return View();
        }
        public IActionResult CarDetail(int id)
        {
            var value = _carService.TGetCarFeature(id);
            return View(value);
        }
		public IActionResult Blog()
		{
			return View();
		}
        public IActionResult Contact()
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
