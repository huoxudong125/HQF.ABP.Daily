using System.Web.Mvc;

namespace HQF.Daily.Web.Controllers
{
    public class AboutController : DailyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}