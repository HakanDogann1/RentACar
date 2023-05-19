using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
