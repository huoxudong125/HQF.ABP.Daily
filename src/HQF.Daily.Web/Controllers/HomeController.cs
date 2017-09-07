using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace HQF.Daily.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DailyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}