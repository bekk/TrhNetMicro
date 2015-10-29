using System;
using System.Collections.Generic;
using System.Linq;
using Abonnement.Data;

namespace Abonnement.Service
{
    public class AbonnementService
    {
        private AbonnementContext _context;
        public AbonnementService()
        {
            _context = new AbonnementContext();
        }
        public void CreateAbonnements(int kundeId, DateTimeOffset start, DateTimeOffset stop)
        {
            var period = ((stop.Year - start.Year) * 12) + stop.Month - start.Month;

            if (period == 0)
            {
                _context.Abonnements.Add(new Data.Abonnement(kundeId, start.Year, start.Month, true));
            }
            else
            {
                for (int i = 0; i < period; i++)
                {
                    _context.Abonnements.Add(new Data.Abonnement(kundeId, start.AddMonths(i).Year, start.AddMonths(i).Month, true));
                }
            }
            
            _context.SaveChanges();
        }

        public List<Data.Abonnement> GetAbonnements(int kundeId)
        {
            return _context.Abonnements.Where(x => x.KundeId == kundeId).ToList();
        }
    }
}