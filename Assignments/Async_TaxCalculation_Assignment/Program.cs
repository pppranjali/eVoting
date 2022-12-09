using Async_TaxCalculation_Assignment;
using System.Diagnostics;

Taxation Operations = new Taxation();
EmployeeCollection employees = new EmployeeCollection();
var timer = Stopwatch.StartNew();

var task1 = Operations.WriteAllDataAsync(employees);
await task1;
var task = Operations.SalarySlip(employees);
var task2 = Operations.MasterFile(employees);
Task.WaitAll(task,task2);

var totalTime = timer.Elapsed.TotalSeconds;
Console.WriteLine(totalTime);