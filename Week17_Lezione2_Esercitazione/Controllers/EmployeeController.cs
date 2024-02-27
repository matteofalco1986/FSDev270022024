using Microsoft.AspNetCore.Mvc;
using Week17_Lezione2_Esercitazione.Models;

namespace Week17_Lezione2_Esercitazione.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string nome, string cognome, string indirizzo, string codiceFiscale, bool isConiugato, int figliACarico, string mansione) { 
            var employee = StaticDb.Add(nome, cognome, indirizzo, codiceFiscale, isConiugato, figliACarico, mansione);
            return RedirectToAction("Index");
        }

    }
}
