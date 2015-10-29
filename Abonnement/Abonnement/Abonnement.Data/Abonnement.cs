using System.ComponentModel.DataAnnotations;

namespace Abonnement.Data
{
    public class Abonnement
    {
        [Key]
        public int KundeId { get; set; }
        public int År { get; set; }
        public int Måned { get; set; }
        public bool Betalt { get; set; }

        public Abonnement()
        {
            
        }
        public Abonnement(int kundeId, int år, int måned, bool betalt)
        {
            KundeId = kundeId;
            År = år;
            Måned = måned;
            Betalt = betalt;
        }
    }
}
