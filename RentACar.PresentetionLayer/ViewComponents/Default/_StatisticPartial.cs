using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentetionLayer.ViewComponents.Default
{
    public class _StatisticPartial:ViewComponent
    {
        private readonly IStatisticService _statisticService;

        public _StatisticPartial(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _statisticService.TGetList();
            return View(values);
        }
    }
}
