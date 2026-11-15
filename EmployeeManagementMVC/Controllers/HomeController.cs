
using System.Diagnostics;
using EmployeeManagementMVC.Models;
using EmployeeManagementMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(
            ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TotalEmployees =
                await _context.Employees.CountAsync();

            ViewBag.TotalDepartments =
                await _context.Employees
                    .Select(e => e.Department)
                    .Distinct()
                    .CountAsync();

            ViewBag.AverageSalary =
                await _context.Employees
                    .Select(e => (decimal?)e.Salary)
                    .AverageAsync() ?? 0;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
