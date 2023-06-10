using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _CarListPartial:ViewComponent
    {
        private readonly ICarService _carService;

        public _CarListPartial(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carService.TGetCarWithBrand();
            return View(values);
        }
    }
}
