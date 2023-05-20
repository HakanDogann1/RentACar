using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class CarFeatureController : Controller
    {
        private readonly ICarFeatureService _carFeatureService;

        public CarFeatureController(ICarFeatureService carFeatureService)
        {
            _carFeatureService = carFeatureService;
        }

        public IActionResult Index()
        {
            var values = _carFeatureService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCarFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCarFeature(CarFeature carFeature)
        {
            _carFeatureService.TInsert(carFeature);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCarFeature(int id)
        {
            var values = _carFeatureService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCarFeature(CarFeature carFeature)
        {
            _carFeatureService.TUpdate(carFeature);
            return RedirectToAction("Index");
        }
    }
}
