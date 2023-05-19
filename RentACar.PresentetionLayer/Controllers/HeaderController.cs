using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class HeaderController : Controller
    {
        private readonly IHeaderService _headerService;

        public HeaderController(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        public IActionResult Index()
        {
            var values = _headerService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateHeader(int id)
        {
            var values = _headerService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateHeader(Header header)
        {
            _headerService.TUpdate(header);
            return RedirectToAction("Index");
        }
    }
}
