using Thread_File_Sync;
Console.WriteLine("Thread Salary file");
EmployeeCollection employees = new EmployeeCollection();
FileOperation operation = new FileOperation();

foreach (Employee employee in employees)
{
    Thread t = new Thread(() => FileOperation.WriteFile(employee));
    t.Name = $"{employee.EmployeeId}-{employee.EmployeeName}";
    t.Start();
}



