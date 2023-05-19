using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _ReserveServicePartial:ViewComponent
    {
        private IReserveServiceService _service;

        public _ReserveServicePartial(IReserveServiceService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _service.TGetList();
            return View(values);
        }
    }
}
