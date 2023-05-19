using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _HeaderPartial:ViewComponent
    {
        private readonly IHeaderService _headerService;

        public _HeaderPartial(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _headerService.TGetList();
            return View(values);
        }
    }
}
