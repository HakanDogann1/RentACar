using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentetionLayer.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public IActionResult Index()
        {
            var values = _statisticService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateStatistic(int id)
        {
            var values = _statisticService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateStatistic(Statistic statistic)
        {
            _statisticService.TUpdate(statistic);
            return RedirectToAction("Index");
        }
    }
}
