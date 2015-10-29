using System.Collections.Generic;
using System.Web.Http;
using KundeData;

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
        public Kunde Post(string forNavn, string etterNavn, string adresse)
        {
            var kunde = Context.Kunder.Create();
            kunde.ForNavn = forNavn;
            kunde.EtterNavn = etterNavn;
            kunde.Adresse = adresse;
            Context.Kunder.Add(kunde);
            Context.SaveChanges();

            return kunde;
        }
    }
}