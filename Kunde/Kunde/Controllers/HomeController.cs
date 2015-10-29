using System.Web.Mvc;

namespace KundeWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("swagger");
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
