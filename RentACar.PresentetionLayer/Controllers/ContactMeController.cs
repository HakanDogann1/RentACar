using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class ContactMeController : Controller
    {
        private readonly IContactMeService _contactMeService;

        public ContactMeController(IContactMeService contactMeService)
        {
            _contactMeService = contactMeService;
        }

        public IActionResult Index()
        {
            var values = _contactMeService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateContactMe(int id)
        {
            var values = _contactMeService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateContactMe(ContactMe contactMe)
        {
            _contactMeService.TUpdate(contactMe);
            return RedirectToAction("Index");
        }
    }
}
