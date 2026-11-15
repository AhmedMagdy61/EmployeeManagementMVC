
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementMVC.Data;

namespace EmployeeManagementMVC.Pages
{
    [Authorize(Roles = "Admin")]
    public class EmployeesSummaryModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EmployeesSummaryModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public int TotalEmployees { get; set; }

        public int TotalDepartments { get; set; }

        public decimal AverageSalary { get; set; }

        public async Task OnGetAsync()
        {
            TotalEmployees = await _context.Employees.CountAsync();

            TotalDepartments = await _context.Employees
                .Select(e => e.Department)
                .Distinct()
                .CountAsync();

            if (TotalEmployees > 0)
            {
                AverageSalary = await _context.Employees
                    .AverageAsync(e => e.Salary);
            }
        }
    }
}
