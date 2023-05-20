using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Dashboard
{
    public class _BlogTablePartial:ViewComponent
    {
        private readonly IBlogService _blogService;

        public _BlogTablePartial(IBlogService blogService)
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
