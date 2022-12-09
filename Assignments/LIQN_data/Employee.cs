using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_data
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }=String.Empty;
        public string Designation { get; set; }=String.Empty;
        public int Salary { get; set; }
        public int DeptNo { get; set; }
    }

    public class EmployeeCollection: List<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee() { EmpNo = 1001, EmpName = "Pranjali", Designation = "Manager", Salary = 55000,DeptNo=1 });
            Add(new Employee() { EmpNo = 1002, EmpName = "Ruchika", Designation = "Developer", Salary = 35000, DeptNo = 8 });
            Add(new Employee() { EmpNo = 1003, EmpName = "Renu", Designation = "Manager", Salary = 63000, DeptNo = 2 });
            Add(new Employee() { EmpNo = 1004, EmpName = "Shreya", Designation = "Manager", Salary = 13000, DeptNo = 3 });
            Add(new Employee() { EmpNo = 1005, EmpName = "Prathamesh", Designation = "Manager", Salary = 93000, DeptNo = 4 });
            Add(new Employee() { EmpNo = 1006, EmpName = "Mohan", Designation = "Developer", Salary = 65000, DeptNo = 11 });
            Add(new Employee() { EmpNo = 1007, EmpName = "Dhirva", Designation = "Developer", Salary = 24000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 1008, EmpName = "Mukesh", Designation = "Developer", Salary = 53000, DeptNo = 7 });
            Add(new Employee() { EmpNo = 1009, EmpName = "Ranbir", Designation = "Manager", Salary = 68000, DeptNo = 15 });
            Add(new Employee() { EmpNo = 1010, EmpName = "Shree", Designation = "Manager", Salary = 89000, DeptNo = 18 });
            Add(new Employee() { EmpNo = 1011, EmpName = "Amol", Designation = "Manager", Salary = 55000, DeptNo = 5});
            Add(new Employee() { EmpNo = 1012, EmpName = "Sakshi", Designation = "Developer", Salary = 35000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 1013, EmpName = "Gauri", Designation = "Developer", Salary = 63000, DeptNo = 14});
            Add(new Employee() { EmpNo = 1014, EmpName = "Jim", Designation = "Manager", Salary = 13000, DeptNo = 1 });
            Add(new Employee() { EmpNo = 1015, EmpName = "Pam", Designation = "Manager", Salary = 94000, DeptNo = 20 });
            Add(new Employee() { EmpNo = 1016, EmpName = "Michael", Designation = "Developer", Salary = 65000, DeptNo = 17 });
            Add(new Employee() { EmpNo = 1017, EmpName = "Joey", Designation = "Manager", Salary = 24000, DeptNo = 3 });
            Add(new Employee() { EmpNo = 1018, EmpName = "Hari", Designation = "Developer", Salary = 53000, DeptNo = 6});
            Add(new Employee() { EmpNo = 1019, EmpName = "Holly", Designation = "Manager", Salary = 68000, DeptNo = 1});
            Add(new Employee() { EmpNo = 1020, EmpName = "Dwight", Designation = "Developer", Salary = 89000, DeptNo = 2 });
            Add(new Employee() { EmpNo = 1021, EmpName = "Rahul", Designation = "Manager", Salary = 89000, DeptNo = 19 });
            Add(new Employee() { EmpNo = 1022, EmpName = "Anjali", Designation = "Developer", Salary = 35000, DeptNo = 2 });
            Add(new Employee() { EmpNo = 1023, EmpName = "Raj", Designation = "Developer", Salary = 63000, DeptNo = 12 });
            Add(new Employee() { EmpNo = 1024, EmpName = "Soham", Designation = "Manager", Salary = 13000, DeptNo = 11 });
            Add(new Employee() { EmpNo = 1025, EmpName = "Rohit", Designation = "Manager", Salary = 94000, DeptNo = 13 });
            Add(new Employee() { EmpNo = 1026, EmpName = "Hema", Designation = "Developer", Salary = 65000, DeptNo = 16 });
            Add(new Employee() { EmpNo = 1027, EmpName = "Sara", Designation = "Manager", Salary = 24000, DeptNo = 3 });
            Add(new Employee() { EmpNo = 1028, EmpName = "Payal", Designation = "Developer", Salary = 53000, DeptNo = 1 });
            Add(new Employee() { EmpNo = 1029, EmpName = "Lili", Designation = "Manager", Salary = 68000, DeptNo = 10});
            Add(new Employee() { EmpNo = 1030, EmpName = "Sahil", Designation = "Developer", Salary = 89000, DeptNo = 9});
        }
    }
}
