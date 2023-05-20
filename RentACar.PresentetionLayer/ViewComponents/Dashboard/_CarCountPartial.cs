using Microsoft.AspNetCore.Mvc;
using RentACar.DataAccessLayer.Concrete;
using System.Linq;

namespace RentACar.PresentetionLayer.ViewComponents.Dashboard
{
    public class _CarCountPartial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.CarsCount = context.Cars.Count();
            return View();
        }
    }
}
