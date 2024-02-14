namespace Aplicatie_Programari_Activitati_Nautice.models
{
    public class Programare
    {

        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string FullName { get { return $"{Nume} {Prenume}"; } }
        public DateTime Data { get; set; }
        public int NrPersoane { get; set; }
        public decimal PretTotal { get; set; }

        public int? ActivitateID { get; set; }
        public Activitate? Activitate { get; set; }

    }
}
