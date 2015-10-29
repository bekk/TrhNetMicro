using System.Data.Entity;

namespace KundeData
{
    public class KundeContext : DbContext
    {
        public DbSet<Kunde> Kunder { get; set; }
    }
}