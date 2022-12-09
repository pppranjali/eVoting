using Linq_p;
using System;
using System.Collections;

List<Employee> employees = new List<Employee>()
{
    new Employee(){ID=1,employeeName="Pranjali"},
    new Employee(){ID=2,employeeName="Pranjali"},
    new Employee(){ID=3,employeeName="Pran"},
    new Employee(){ID=4,employeeName="PP"},

};
var empQuery = from emp in employees
               select new Employee
               {
                   ID = emp.ID
               };


//foreach (Employee emp in empQuery)
//{
//    Console.WriteLine(emp.ID);
//    Console.WriteLine(emp.employeeName);
//}

var lambdaQuery = employees.Where(e => e.employeeName=="Pranjali");
foreach (Employee emp in lambdaQuery)
{
    Console.WriteLine(emp.employeeName);
}
//var lambdaQuery1 = employees.Select(e => e);
//foreach (Employee emp in lambdaQuery1)
//{
//    Console.WriteLine(emp.ID);
//    Console.WriteLine(emp.employeeName);
//}