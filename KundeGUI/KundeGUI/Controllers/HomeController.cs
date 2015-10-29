using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Flurl.Http;
using KundeGUI.Models;

namespace KundeGUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> NewUser(NewUserViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var kunde = await "http://trhnetmicro-kunde.azurewebsites.net/Kunde"
                .PostJsonAsync(model)
                .ReceiveJson<Kunde>();

            try {
                await "http://abonnement.azurewebsites.net/api/abonnement"
                    .PostJsonAsync(new {
                        KundeId = kunde.Id,
                        Start = DateTimeOffset.Now,
                        Stopp = DateTimeOffset.Now
                    });
            } catch (Exception) {
                
                throw;
            }

            return RedirectToAction("Takk", kunde);
        }

        public ActionResult Takk()
        {
            return View();
        }
    }
}