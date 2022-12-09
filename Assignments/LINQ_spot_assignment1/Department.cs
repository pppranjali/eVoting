using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_spot_assignment1
{
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; } = string.Empty;  
        public int Capacity {get;set; } 
        public string Location { get; set; } = string.Empty;
    }
    public class DepartmentCollection:List<Department>
    {
        public  DepartmentCollection()
        {
            Add(new Department() { DeptNo = 1, DeptName = "IT", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 2, DeptName = "Support", Capacity = 8, Location = "Mumbai" });
            Add(new Department() { DeptNo = 1, DeptName = "IT", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 1, DeptName = "IT", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 2, DeptName = "Support", Capacity = 8, Location = "Mumbai" });
            Add(new Department() { DeptNo = 1, DeptName = "IT", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 3, DeptName = "Managment", Capacity = 8, Location = "Delhi" });
            Add(new Department() { DeptNo = 1, DeptName = "Support", Capacity = 8, Location = "Mumbai" });
            Add(new Department() { DeptNo = 3, DeptName = "Managment", Capacity = 8, Location = "Delhi" });
            Add(new Department() { DeptNo = 2, DeptName = "IT", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 1, DeptName = "IT", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 1, DeptName = "Support", Capacity = 8, Location = "Mumbai" });
            Add(new Department() { DeptNo = 3, DeptName = "Managment", Capacity = 12, Location = "Delhi" });
            Add(new Department() { DeptNo = 2, DeptName = "IT", Capacity = 12, Location = "Mumbai" });
        }
    }

}
