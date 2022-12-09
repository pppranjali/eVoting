using Mypractice;
EmployeeCollection employees = new EmployeeCollection();

var MethodQuery = employees.Where(i =>  i.Id>2 ).ToList();
var MethodQ = employees.ToList();
var QueryType = from emp in employees
                select emp;

var MethodQuery1 = (employees.Select(i => new 
{
    StudentId = i.Id,
    Name = i.Name
})).ToList();
foreach(var em in MethodQuery1)
{
    Console.WriteLine(em.StudentId);
}