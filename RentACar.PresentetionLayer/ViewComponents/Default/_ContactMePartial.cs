using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _ContactMePartial:ViewComponent
    {
        private readonly IContactMeService _contactMeService;

        public _ContactMePartial(IContactMeService contactMeService)
        {
            _contactMeService = contactMeService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _contactMeService.TGetList();
            return View(values);
        }
    }
}
