using System.Web.Mvc;

namespace AngularMVC.Web.Controllers
{
    public class HomeController : AngularMVCControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}