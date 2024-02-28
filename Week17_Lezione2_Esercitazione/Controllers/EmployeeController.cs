using Microsoft.AspNetCore.Mvc;
using Week17_Lezione2_Esercitazione.Models;

namespace Week17_Lezione2_Esercitazione.Controllers
{
    public class EmployeeController : Controller
    {
        // Index page. Ritorno la action Index del controller Employee passando la lista come argomento
        public IActionResult Index()
        {
            return View(StaticDb.GetEmployees());
        }

        // Add form vuoto
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST form
        [HttpPost]
        public IActionResult Add(Employee employee) 
        { 
            var newEmployee = StaticDb.Add(employee);
            var newEmployeeId = newEmployee.Id;
            return RedirectToAction("Index");
        }

    }
}
