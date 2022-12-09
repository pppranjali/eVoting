using CS_EF_DbFirst.DataAccess;
using CS_EF_DbFirst.Models;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("EF COre DB First");
try
{
    //EmployeeDataAccess empds = new EmployeeDataAccess();

    //Console.WriteLine($"USing Traditional DbCOntext = {JsonSerializer.Serialize( await empds.GetDataAsync())}");
    //Console.WriteLine();
    //Console.WriteLine($"USing LINQ = {JsonSerializer.Serialize( await empds.GetDataLINQAsync())}");
    //Console.WriteLine();
    //Console.WriteLine($"Using Orderby {JsonSerializer.Serialize( await empds.GetDataLINQOrderByAsync())}");


    //Console.WriteLine($"Using Sync {JsonSerializer.Serialize(JsonSerializer.Serialize(empds.GetDataLINQSync()))}");

    DepartmentDataAccess deprds = new DepartmentDataAccess();

    var res = await deprds.GetAsync();
    Print(res);
    Console.WriteLine();
    //var deptSIngle = await deprds.GetAsync(202);
    //Console.WriteLine(deptSIngle.DeptName);
    Console.WriteLine();
    var d = new Department() {DeptNo = 204, DeptName = "Dept_204", Location = "Banglore", Capacity = 105};
    var e = new Employee() { DeptNo = 10, EmpName = "Pranjali", Designation = "Lead", Salary=3000,EmpNo=60,};
   // await deprds.CreateAsync(d);
    await deprds.UpdateAsync(d.DeptNo, d);
    //await deprds.DeleteAsync(d.DeptNo);
    Console.WriteLine();
    res = await deprds.GetAsync();
    Print(res);
}
catch (Exception ex)
{
    Console.WriteLine($"Error Occurred {ex.Message}");
}

Console.ReadLine();

static void Print(IEnumerable<Department> dept)
{
    Console.WriteLine(JsonSerializer.Serialize(dept));
}