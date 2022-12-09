using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundThreadAssignment
{   
        public class Employee
        {
            public string EmployeeName { get; set; } = string.Empty;
            public int DepartmentId { get; set; }
            public int EmployeeId { get; set; }
            public int NumberOfExtraShift { get; set; }
            public int BasicPay { get; set; }
            public decimal Tax { get; set; }
            public decimal Salary { get; set; }

        }
        public class EmployeeCollection : Dictionary<int,Employee>
        {
            public EmployeeCollection()
            {
                Add(1,new Employee() { EmployeeId = 1, EmployeeName = "Pranjali", NumberOfExtraShift = 2, BasicPay = 5000, Tax = 0, Salary = 0, DepartmentId=1});
                Add(2,new Employee() { EmployeeId = 2, EmployeeName = "Ruchika",  NumberOfExtraShift = 9, BasicPay = 5000, Tax = 0, Salary = 0, DepartmentId = 1 });
                Add(3,new Employee() { EmployeeId = 3, EmployeeName = "Mrunal", NumberOfExtraShift = 8, BasicPay = 6000, Tax = 0, Salary = 0,DepartmentId = 8 });
                Add(4,new Employee() { EmployeeId = 4, EmployeeName = "Raj",  NumberOfExtraShift = 5, BasicPay = 3000, Tax = 0, Salary = 0, DepartmentId = 2 });
                Add(5,new Employee() { EmployeeId = 5, EmployeeName = "Rohan",  NumberOfExtraShift = 7, BasicPay = 3000, Tax = 0, Salary = 0 , DepartmentId = 3 });
                Add(6,new Employee() { EmployeeId = 6, EmployeeName = "Parth",  NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 1 });
                Add(7,new Employee() { EmployeeId = 7, EmployeeName = "Divyansh", NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 6 });
                Add(8,new Employee() { EmployeeId = 8, EmployeeName = "Prashant",  NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0,  DepartmentId = 4 });
                Add(9,new Employee() { EmployeeId = 9, EmployeeName = "Pratik",  NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 2 });
                Add(10,new Employee() { EmployeeId = 10, EmployeeName = "Santosh", NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 1 });
                Add(11,new Employee() { EmployeeId = 11, EmployeeName = "Mukund",  NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 4 });
                Add(12,new Employee() { EmployeeId = 12, EmployeeName = "Ankita",  NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 5 });
                Add(13,new Employee() { EmployeeId = 13, EmployeeName = "Rishika",  NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 5 });
                Add(14,new Employee() { EmployeeId = 14, EmployeeName = "Shubhamkar", NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 2 });
                Add(15,new Employee() { EmployeeId = 15, EmployeeName = "Pratham",  NumberOfExtraShift = 4, BasicPay = 4000, Tax = 0, Salary = 0 , DepartmentId = 9 });
            }


        }
    }

