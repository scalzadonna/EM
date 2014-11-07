using System.Web.Mvc;

namespace ExtramileManager.Web.Controllers
{
    public class HomeController : ExtramileManagerControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}