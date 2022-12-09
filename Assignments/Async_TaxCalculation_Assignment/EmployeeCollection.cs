using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_TaxCalculation_Assignment
{
    public class Employee
    {
        public string EmployeeName { get; set; } = string.Empty;
        public int EmployeeId { get; set; } 
        public int NumberOfExtraShift { get; set; }
        public int BasicPay { get; set;}
        public decimal Tax { get; set;} 
        public decimal Salary { get; set;}

    }
   public class EmployeeCollection: List<Employee>
   {
        public EmployeeCollection()
        {
            Add(new Employee(){ EmployeeId=1,EmployeeName="Pranjali",NumberOfExtraShift=2,BasicPay=5000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=2,EmployeeName="Ruchika",NumberOfExtraShift=9,BasicPay=5000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=3,EmployeeName="Mrunal",NumberOfExtraShift=8,BasicPay=6000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=4,EmployeeName="Raj",NumberOfExtraShift=5,BasicPay=3000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=5,EmployeeName="Rohan",NumberOfExtraShift=7,BasicPay=3000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=6,EmployeeName="Parth",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=7,EmployeeName="Divyansh",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=8,EmployeeName="Prashant",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=9,EmployeeName="Pratik",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=10,EmployeeName="Santosh",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=11,EmployeeName="Mukund",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=12,EmployeeName="Ankita",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=13,EmployeeName="Rishika",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=14,EmployeeName="Shubhamkar",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
            Add(new Employee(){ EmployeeId=15,EmployeeName="Pratham",NumberOfExtraShift=4,BasicPay=4000,Tax=0,Salary=0});
        }

        
   }

}
