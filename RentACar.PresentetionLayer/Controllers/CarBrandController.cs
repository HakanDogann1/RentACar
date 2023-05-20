using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class CarBrandController : Controller
    {
        private readonly ICarBrandService _carBrandService;

        public CarBrandController(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        public IActionResult Index()
        {
            var values = _carBrandService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateCarBrand(int id)
        {
                var values = _carBrandService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCarBrand(CarBrand carBrand)
        {
            _carBrandService.TUpdate(carBrand);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddCarBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCarBrand(CarBrand carBrand)
        {
            _carBrandService.TInsert(carBrand);
            return RedirectToAction("Index");
        }
    }
}
