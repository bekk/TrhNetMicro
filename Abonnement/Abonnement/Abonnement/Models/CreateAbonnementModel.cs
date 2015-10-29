using System;

namespace Abonnement.Models
{
    public class CreateAbonnementModel
    {
        public int KundeId { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset Stop { get; set; }
    }
}
