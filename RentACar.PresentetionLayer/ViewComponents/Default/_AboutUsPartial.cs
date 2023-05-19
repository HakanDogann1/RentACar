using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _AboutUsPartial:ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _AboutUsPartial(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutUsService.TGetList();
            return View(values);
        }
    }
}
