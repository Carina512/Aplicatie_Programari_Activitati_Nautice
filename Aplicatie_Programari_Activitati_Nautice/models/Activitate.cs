namespace Aplicatie_Programari_Activitati_Nautice.models
{
    public class Activitate
    {

        public int ID { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public string Durata { get; set; }
        public decimal Pret { get; set; }

        public ICollection<Programare>? Programari { get; set; }


    }
}
