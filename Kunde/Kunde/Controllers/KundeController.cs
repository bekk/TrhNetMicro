using System.Collections.Generic;
using System.Web.Http;
using KundeData;
using KundeWeb.Models;

namespace KundeWeb.Controllers
{
    public class KundeController : ApiController
    {
        public KundeController()
        {
            Context = new KundeContext();
        }

        public KundeContext Context { get; set; }

        // GET api/values
        public IEnumerable<Kunde> Get()
        {
            return Context.Kunder;
        }

        // GET api/values/5
        public Kunde Get(int id)
        {
            return Context.Kunder.Find(id);
        }

        // POST api/values
        public Kunde Post(NyKundeBindingModel model)
        {
            var kunde = Context.Kunder.Create();
            kunde.ForNavn = model.ForNavn;
            kunde.EtterNavn = model.EtterNavn;
            kunde.Adresse = model.Adresse;
            Context.Kunder.Add(kunde);
            Context.SaveChanges();
            return kunde;
        }
    }
}