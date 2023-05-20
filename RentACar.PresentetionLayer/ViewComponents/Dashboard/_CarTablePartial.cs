using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Dashboard
{
    public class _CarTablePartial:ViewComponent
    {
        private readonly ICarService _carService;

        public _CarTablePartial(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carService.TGetLAs4Car();
            return View(values);
        }
    }
}
