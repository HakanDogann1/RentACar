using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class ReserveController : Controller
    {
        private readonly IReserveService _reserveService;

        public ReserveController(IReserveService reserveService)
        {
            _reserveService = reserveService;
        }

        public IActionResult Index()
        {
            var values = _reserveService.TGetList();
            return View(values);
        }
        public IActionResult DeleteReserve(int id)
        {
            var values = _reserveService.TGetById(id);
            _reserveService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
