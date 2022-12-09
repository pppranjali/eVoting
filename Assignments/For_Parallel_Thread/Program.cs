using For_Parallel_Thread;
EmployeeCollection empList = new EmployeeCollection();

Parallel.For(0, empList.Count, (i) =>
{
    empList[i] = ProcessTax.CalculateTax(empList[i]);
    FileOperation.WriteFile(empList[i]);
    Console.WriteLine($"Parallel Tax of  {empList[i].EmployeeId}  {empList[i].EmployeeName} is = {empList[i].Tax}");
});