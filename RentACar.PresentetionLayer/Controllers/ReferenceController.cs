using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class ReferenceController : Controller
    {
        private readonly IReferenceService _referenceService;

        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        public IActionResult Index()
        {
            var values = _referenceService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReference(Reference reference)
        {
            _referenceService.TInsert(reference);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateReference(int id)
        {
            var values = _referenceService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateReference(Reference reference)
        {
            _referenceService.TUpdate(reference);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteReference(int id)
        {
            var values = _referenceService.TGetById(id);
            _referenceService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
