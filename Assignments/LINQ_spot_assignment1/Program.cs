// See https://aka.ms/new-console-template for more information
using LINQ_spot_assignment1;
Console.WriteLine("LINQ QUERY");
EmployeeCollection employee = new EmployeeCollection();
DepartmentCollection department = new DepartmentCollection();

Console.WriteLine("-------------------------------1st query-----------------------------------");
var MaxSalary = from emp in employee
                group emp by emp.DeptNo into deptgroup
                 select new
                 {
                     DeptName = deptgroup.Key,
                     Sal = deptgroup.MaxBy(e => e.Salary),
                 };

foreach (var item in MaxSalary)
{
    Console.WriteLine($"Department: {item.DeptName} Employee Name: {item.Sal.EmpName} Employee ID:  {item.Sal.EmpNo} Salary: {item.Sal.Salary} ");
      
}

Console.WriteLine("---------------------------------2nd query---------------------------------");
var SumSalary = (from emp in employee
                 join dept in department on emp.DeptNo equals dept.DeptNo
                 group emp by dept.DeptName into deptgroup
                 select new
                 {
                     DeptName = deptgroup.Key,
                     Salary = deptgroup.Sum(e => e.Salary),
                 }).ToList();

foreach (var item in SumSalary)
{
    Console.WriteLine($"Department: {item.DeptName}  Salary sum amount: {item.Salary} ");
}

/*var DeptDetails = from emp in employee
                  join dept in department on emp.DeptNo equals dept.DeptNo
                  group emp by dept.DeptName into deptname
                  select new
                  {
                      all=deptname
                  };

foreach (var item in DeptDetails)
{
    foreach (var item2 in item.all)
    {
        Console.WriteLine($"{item2.EmpNo}     {item2.EmpName}     {item2.DeptNo}");
    }
}

Console.WriteLine("--------------------------------3rd query----------------------------------");
var DeptDetails = from emp in employee
                  join dept in department on emp.DeptNo equals dept.DeptNo
                  group emp by dept.DeptName into deptgroup
                  select new
                  {
                      DeptName = deptgroup.Key,
                      val = deptgroup
                  };

foreach(var item in DeptDetails)
{
    Console.WriteLine($"Department: {item.DeptName}");
    foreach (var v in item.val)
    {
        Console.WriteLine($"Empolyee Number: {v.EmpNo}  Employee Name: {v.EmpName} Designation {v.Designation} Salary: {v.Salary} Department Number: {v.DeptNo} ");
    }
}
Console.WriteLine("-----------------------------------4th query-------------------------------");

var Locationcount = from emp in employee
                    join dept in department on emp.DeptNo equals dept.DeptNo
                    group emp by dept.Location into locgroup
                    select new
                    {
                        Location = locgroup.Key,
                        count = locgroup.Count()
                    };
foreach (var item in Locationcount)
{
    Console.WriteLine($"Location : {item.Location}   Count: {item.count}");  
}
Console.WriteLine("-----------------------------------5th query-------------------------------");


var Locationdetail = from emp in employee
                    join dept in department on emp.DeptNo equals dept.DeptNo
                    group emp by dept.Location into locgroup
                    select new
                    {
                        Location = locgroup.Key,
                        det = locgroup
                    };
foreach (var item in Locationdetail)
{
    Console.WriteLine($"Location: {item.Location}");
    foreach (var v in item.det)
    {
        Console.WriteLine($"Empolyee Number: {v.EmpNo}    Employee Name: {v.EmpName}   Designation {v.Designation}   Salary: {v.Salary}   Department Number: {v.DeptNo} Location:{item.Location} ");
    }
}*/