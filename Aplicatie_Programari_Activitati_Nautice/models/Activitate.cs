using System.ComponentModel.DataAnnotations;

namespace Aplicatie_Programari_Activitati_Nautice.models
{
    public class Activitate
    {

        public int ID { get; set; }
        [Required]
        
        public string Denumire { get; set; }
        [Required]
        
        public string Descriere { get; set; }
        [Required]
        public string Durata { get; set; }
        [Required]
        public decimal Pret { get; set; }

        public ICollection<Programare>? Programari { get; set; }


    }
}
