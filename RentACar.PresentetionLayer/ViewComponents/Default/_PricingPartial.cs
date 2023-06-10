using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
	public class _PricingPartial:ViewComponent
	{
		private readonly ICarService _carService;

		public _PricingPartial(ICarService carService)
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
