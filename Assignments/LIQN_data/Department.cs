using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_data
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
            Add(new Department() { DeptNo = 3, DeptName = "Managment", Capacity = 8, Location = "Delhi" });
            Add(new Department() { DeptNo = 4, DeptName = "Computer", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 5, DeptName = "ENTC", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 6, DeptName = "Java", Capacity = 8, Location = "Mumbai" });
            Add(new Department() { DeptNo = 7, DeptName = ".Net", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 8, DeptName = "React", Capacity = 8, Location = "Mumbai" });
            Add(new Department() { DeptNo = 9, DeptName = "Flutter", Capacity = 8, Location = "Delhi" });
            Add(new Department() { DeptNo = 10, DeptName = "IOS", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 11, DeptName = "Android", Capacity = 12, Location = "Pune" });
            Add(new Department() { DeptNo = 12, DeptName = "Data Science", Capacity = 8, Location = "Mumbai" });
            Add(new Department() { DeptNo = 13, DeptName = "Cloud", Capacity = 12, Location = "Delhi" });
            Add(new Department() { DeptNo = 14, DeptName = "Production", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 15, DeptName = "Support", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 16, DeptName = "Support", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 17, DeptName = "Support", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 18, DeptName = "Support", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 19, DeptName = "Support", Capacity = 12, Location = "Mumbai" });
            Add(new Department() { DeptNo = 20, DeptName = "Support", Capacity = 12, Location = "Mumbai" });
        }
    }

}
