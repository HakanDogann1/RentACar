using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public IActionResult Index()
        {
            var values = _aboutUsService.TGetList();
            return View(values);
        }

        public IActionResult UpdateAboutUs(int id)
        {
            var values = _aboutUsService.TGetById(id);
            return View(values);
        }
    }
}
