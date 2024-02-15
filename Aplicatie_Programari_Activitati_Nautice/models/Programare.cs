using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace Aplicatie_Programari_Activitati_Nautice.models
{
    public class Programare
    {
        

        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Nume { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Prenume { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get { return $"{Nume} {Prenume}"; } }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public int NrPersoane { get; set; }

        [Required]
        public int? ActivitateID { get; set; }
        public Activitate? Activitate { get; set; }

    }
}
