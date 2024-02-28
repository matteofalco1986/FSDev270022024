namespace Week17_Lezione2_Esercitazione.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Indirizzo { get; set; }
        public string? CodiceFiscale { get; set; }
        public bool IsConiugato { get; set; }
        public int? FigliACarico{ get; set; }
        public string? Mansione { get; set; }

    }
}
