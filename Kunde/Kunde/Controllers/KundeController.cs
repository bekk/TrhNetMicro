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
        public IEnumerable<KundeData.Kunde> Get()
        {
            return Context.Kunder;
        }

        // GET api/values/5
        public KundeData.Kunde Get(int id)
        {
            return Context.Kunder.Find(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
