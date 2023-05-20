using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.PresentetionLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarBrandService _carBrandService;
        private readonly ICarTransmissionService _carTransmissionService;

        public CarController(ICarService carService, ICarBrandService carBrandService, ICarTransmissionService carTransmissionService)
        {
            _carService = carService;
            _carBrandService = carBrandService;
            _carTransmissionService = carTransmissionService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetBrandAndTransmission();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCar()
        {
            List<SelectListItem> list1 = (from x in _carBrandService.TGetList()
                                   select new SelectListItem
                                   {
                                       Text = x.CarBrandName,
                                       Value=x.CarBrandID.ToString()
                                   }).ToList();
            ViewBag.carWithBrand = list1;

            List<SelectListItem> list2= (from x in _carTransmissionService.TGetList()
                                       select new SelectListItem
                                       {
                                           Text= x.CarTransmissionName,
                                           Value = x.CarTransmissionID.ToString()
                                       }).ToList();
            ViewBag.carWithTransmission = list2;
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car car) 
        {
            
            _carService.TInsert(car);
        return RedirectToAction("Index");
        }
    }
}
