using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.PresentetionLayer.Controllers
{
    public class BlogCommentController : Controller
    {
        private readonly IBlogCommentService _blogCommentService;
        private readonly IBlogService _blogService;

        public BlogCommentController(IBlogCommentService blogCommentService, IBlogService blogService)
        {
            _blogService = blogService;
            _blogCommentService = blogCommentService;
        }

        public IActionResult Index()
        {
           
            var values = _blogCommentService.TGetBlogCommentWithBlog();
            return View(values);
        }

       public IActionResult DeleteBlogComment(int id)
        {
            var values = _blogCommentService.TGetById(id);
            _blogCommentService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
