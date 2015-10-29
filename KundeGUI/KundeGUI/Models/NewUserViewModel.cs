using System.ComponentModel.DataAnnotations;

namespace KundeGUI.Models
{
    public class NewUserViewModel
    {
        [Required]
        public string ForNavn { get; set; }
        [Required]
        public string EtterNavn { get; set; }
        [Required]
        public string Adresse { get; set; }
    }
}