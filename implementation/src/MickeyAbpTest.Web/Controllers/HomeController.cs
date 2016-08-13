using System.Web.Mvc;

namespace MickeyAbpTest.Web.Controllers
{
    public class HomeController : MickeyAbpTestControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}