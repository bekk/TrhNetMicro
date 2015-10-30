using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Flurl.Http;
using KundeGUI.Models;

namespace KundeGUI.Controllers
{
    public class HomeController : Controller
    {
        private const string AbonnementUrl = "http://abonnement.azurewebsites.net/api/abonnement";

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

            var kunde = await "http://trhnetmicro-kunde.azurewebsites.net/api/Kunde"
                .PostJsonAsync(model)
                .ReceiveJson<Kunde>();

            await AbonnementUrl
                .PostJsonAsync(new {
                    KundeId = kunde.Id,
                    Start = DateTimeOffset.Now,
                    Stopp = DateTimeOffset.Now
                });
            
            return RedirectToAction("Oversikt", kunde.Id);
        }

        public ActionResult Takk()
        {
            return View();
        }

        public async Task<ActionResult> Oversikt(int id)
        {
            var abonnementer = await AbonnementUrl.GetJsonAsync<IEnumerable<Abonnement>>();

            var viewModel = new AbonnementerViewModel(abonnementer);

            return View(viewModel);
        }
    }

    public class AbonnementerViewModel
    {
        public AbonnementerViewModel(IEnumerable<Abonnement> abonnementer)
        {
            Abonnementer = abonnementer;
        }

        public IEnumerable<Abonnement> Abonnementer { get; set; }
    }

    public class Abonnement
    {
        
    }
}