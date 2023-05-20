using Microsoft.AspNetCore.Mvc;
using RentACar.DataAccessLayer.Concrete;
using System.Linq;

namespace RentACar.PresentetionLayer.ViewComponents.Dashboard
{
    public class _YearlyBreakupPartial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.CarPriceAvarage = context.Cars.Average(x => x.CarPrice);
            return View();
        }
    }
}
