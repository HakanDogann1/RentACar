using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _NavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
