using CS_EF_FirstCode.Models;
InfoDbContext ctx = new InfoDbContext();
Department d = new Department();

d.DepartmentName = "Sales";
ctx.Departments.Add(d);
//ctx.SaveChanges();

Employee e = new Employee();
e.EmployeeName = "Soham";
e.EmployeeAge = 23;
e.DepartmentID = 2;
ctx.Employees.Add(e);
//ctx.SaveChanges();

