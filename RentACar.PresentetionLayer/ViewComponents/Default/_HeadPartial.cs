using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
