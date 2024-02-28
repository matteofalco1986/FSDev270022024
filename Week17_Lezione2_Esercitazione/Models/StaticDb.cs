using System.Xml.Serialization;

namespace Week17_Lezione2_Esercitazione.Models
{
    public class StaticDb
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

        public static Employee Add(Employee employee)
        {
            _maxId++;
            employee.Id = _maxId;
            _employees.Add(employee);
            return employee;
        }
    }
}
