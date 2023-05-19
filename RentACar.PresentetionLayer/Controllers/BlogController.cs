using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var values = _blogService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
           _blogService.TInsert(blog);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var values = _blogService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            _blogService.TUpdate(blog);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBlog(int id)
        {
            var values = _blogService.TGetById(id);
            _blogService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
