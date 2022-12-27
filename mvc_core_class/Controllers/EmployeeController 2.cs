using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_core_class.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_core_class.Controllers
{
    public class EmployeeController : Controller
    {
        private Dictionary<Guid, Employee>  employees = new();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public void AddEmployees(Employee newEmployee)
        {
            employees[newEmployee.empGuid] = newEmployee;
        }

        public void UpdateEmployee(Guid empGuid, Employee updatedEmployee)
        {
            employees[empGuid] = updatedEmployee;
        }

        public void DeleteEmployee(Guid empGuid)
        {
            employees.Remove(empGuid);
        }

        public List<Employee> GetAllEmployees()
        {
            List<Guid> uidKeys = employees.Keys.ToList();
            List<Employee> allEmployees = uidKeys.Select(gUid => employees[gUid]).ToList();
            return allEmployees;
        }

        public IActionResult AllEmployees()
        {
            Employee[] employees = {
                new Employee("Fawad", 03169400169, "Peshawar"),
                new Employee("Sajjad Ahmad", 03109666880, "Peshawar"),
                new Employee("Ali", 03199993301, "Hangoo"),
            };

            List<Employee> allEmployees = new List<Employee>(employees);

            ViewData["allEmployees"] = allEmployees;

            return View();
        }
    }
}