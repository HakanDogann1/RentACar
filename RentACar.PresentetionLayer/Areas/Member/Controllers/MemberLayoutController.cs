using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentetionLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult MemberSideBarPartial()
        {
            return PartialView();
        }
      
    }
}
