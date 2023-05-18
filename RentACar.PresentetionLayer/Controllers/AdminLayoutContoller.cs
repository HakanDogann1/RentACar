using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.Controllers
{
	public class AdminLayoutContoller : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult Head()
		{
			return PartialView();
		}
		public PartialViewResult Sidebar()
		{
			return PartialView();
		}
		public PartialViewResult Header()
		{
			return PartialView();
		}
		public PartialViewResult Script()
		{
			return PartialView();
		}
	}
}
