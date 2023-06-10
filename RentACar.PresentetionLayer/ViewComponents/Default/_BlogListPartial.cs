using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _BlogListPartial:ViewComponent
    {
        private readonly IBlogService _blogService;

        public _BlogListPartial(IBlogService blogService)
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
