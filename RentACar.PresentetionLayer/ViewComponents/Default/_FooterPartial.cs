using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
