using System.ComponentModel.DataAnnotations;

namespace Aplicatie_Programari_Activitati_Nautice.models
{
    public class Review
    {

        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Name { get; set; }
        [Required]
        public string Opinie { get; set; }
        [Required]
        [Range(0, 5, ErrorMessage = "Nota trebuie să fie între 0 și 5")]
        public int Nota { get; set; }

    }
}
