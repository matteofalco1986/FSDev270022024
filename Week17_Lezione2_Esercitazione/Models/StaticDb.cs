using System.Xml.Serialization;

namespace Week17_Lezione2_Esercitazione.Models
{
    public static class StaticDb
    {
        public static int _maxId = 2;
        private static List<Employee> _employees = [
            new Employee() { Id = 1, Nome = "Giancarlo", Cognome = "Gobbi", Indirizzo = "Via di qua 32, Milano", CodiceFiscale = "GNCGBB86P29E897S", IsConiugato = true, FigliACarico = 3, Mansione = "Manovale" },
            new Employee() { Id = 2, Nome = "Brambilla", Cognome = "Fumagalli", Indirizzo = "Via cadreg, Lampedusa", CodiceFiscale = "BRMFMG32T12R232B", IsConiugato = false, FigliACarico = 0, Mansione = "Vampiro" }
        ];

        public static List<Employee> GetEmployees()
        {
            return _employees;
        }

        public static Employee Add(string nome, string cognome, string indirizzo, string codiceFiscale, bool isConiugato, int figliACarico, string mansione)
        {
            _maxId++;
            var employee = new Employee() { Id = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, CodiceFiscale = codiceFiscale, IsConiugato = isConiugato, FigliACarico = figliACarico, Mansione = mansione};
            return employee;
        }
    }
}
