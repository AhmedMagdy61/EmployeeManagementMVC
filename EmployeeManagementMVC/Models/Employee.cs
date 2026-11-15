
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Range(0, 1000000,
            ErrorMessage = "Salary must be between 0 and 1,000,000")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Department must be between 2 and 50 characters")]
        public string Department { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; } = DateTime.Today;
    }
}
