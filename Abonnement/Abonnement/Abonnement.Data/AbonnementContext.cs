using System.Data.Entity;

namespace Abonnement.Data
{
    public class AbonnementContext : DbContext
    {
        public DbSet<Abonnement> Abonnements { get; set; }
    }
}
