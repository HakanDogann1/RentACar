using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class ReserveServiceController : Controller
    {
        private readonly IReserveServiceService _reserveService;

        public ReserveServiceController(IReserveServiceService reserveService)
        {
            _reserveService = reserveService;
        }

        public IActionResult Index()
        {
            var values = _reserveService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddReserveService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReserveService(ReserveService reserveService)
        {
            _reserveService.TInsert(reserveService);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateReserveService(int id)
        {
            var values = _reserveService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateReserveService(ReserveService reserveService)
        {
            _reserveService.TUpdate(reserveService);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteReserveService(int id)
        {
            var values = _reserveService.TGetById(id);
            _reserveService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
