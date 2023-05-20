using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Dashboard
{
    public class _ReserveTablePartial:ViewComponent
    {
        IReserveService _service;

        public _ReserveTablePartial(IReserveService service)
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
