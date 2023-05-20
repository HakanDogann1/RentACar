using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;

namespace RentACar.PresentetionLayer.Controllers
{
    public class CarTransmissionController : Controller
    {
        private readonly ICarTransmissionService _carTransmissionService;

        public CarTransmissionController(ICarTransmissionService carTransmissionService)
        {
            _carTransmissionService = carTransmissionService;
        }

        public IActionResult Index()
        {
            var values = _carTransmissionService.TGetList();
            return View(values);
        }
    }
}
