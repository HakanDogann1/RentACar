using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
