using System.Data.Entity;

namespace Kunde.Data
{
    public class KundeContext : DbContext
    {
        DbSet<Kunde> Kunder { get; set; }
    }
}