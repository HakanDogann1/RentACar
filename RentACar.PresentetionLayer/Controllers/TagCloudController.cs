using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class TagCloudController : Controller
    {
        private readonly ITagCloudService _tagCloudService;

        public TagCloudController(ITagCloudService tagCloudService)
        {
            _tagCloudService = tagCloudService;
        }

        public IActionResult Index()
        {
            var values = _tagCloudService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTagCloud()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddTagCloud(TagCloud tagCloud)
        {
            _tagCloudService.TInsert(tagCloud);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTagCloud(int id)
        {
            var values = _tagCloudService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTagCloud(TagCloud tagCloud)
        {
            _tagCloudService.TUpdate(tagCloud);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTagCloud(int id)
        {
            var values = _tagCloudService.TGetById(id);
            _tagCloudService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
