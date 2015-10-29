using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonnement.Domain.Entities
{
    public class Abonnement
    {
        [Key]
        public int KundeId { get; set; }
        public int År { get; set; }
        public int Måned { get; set; }
        public bool Betalt { get; set; }
    }
}
