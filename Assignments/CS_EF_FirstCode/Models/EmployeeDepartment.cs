using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CS_EF_FirstCode.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required,StringLength(400)]
        public string EmployeeName { get; set; }
        [Required]
        public int EmployeeAge { get; set; }
        public Department department { get; set; }
        public int DepartmentID { get; set; }
    }
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
