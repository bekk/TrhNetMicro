using System;
using System.Collections.Generic;
using System.Web.Http;
using Abonnement.Models;
using Abonnement.Service;

namespace Abonnement.Controllers
{
    public class AbonnementController : ApiController
    {
        private readonly AbonnementService _service;

        public AbonnementController()
        {
            _service = new AbonnementService();
        }

        // GET api/abonemment/5
        public IEnumerable<Data.Abonnement> Get(int kundeId)
        {
            return _service.GetAbonnements(kundeId);
        }

        // POST api/abonnement
        public void Post(CreateAbonnementModel model)
        {
            _service.CreateAbonnements(model.KundeId, model.Start, model.Stop);
        }
    }
}
