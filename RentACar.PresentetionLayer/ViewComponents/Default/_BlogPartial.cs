using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.EntityLayer.Concrete;
using System.Linq;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _BlogPartial:ViewComponent
    {
        private readonly IBlogService _blogService;
        public _BlogPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
          
            var values = _blogService.TGetList();
            return View(values);
        }
    }
}
