using Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
    public class EmployeesController : Controller
    {
        SignalREmployeesContext db;

        public EmployeesController( SignalREmployeesContext _db)
        {
            db = _db;
        }
            
        public IActionResult AddEmployee()
        {
            return View("AddEmployeeForm");
        }

        public IActionResult DisplayEmployees()
        {
            return View("DisplayEmployees", db.Employees.ToList());
        }
    }
}
