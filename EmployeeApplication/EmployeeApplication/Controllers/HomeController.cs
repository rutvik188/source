using EmployeeApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeApplication.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public IActionResult Privacy()
        {
            return View();
        }

    
    }
}