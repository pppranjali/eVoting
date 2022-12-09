using BackGroundThreadAssignment;
Employee employee = new Employee();
DepartmentCollection department = new DepartmentCollection();
EmployeeCollection employees = new EmployeeCollection();
Console.WriteLine("Enter the Department Name you want to search:");
int departmentId = Convert.ToInt32(Console.ReadLine());
var bgThread = new Thread(() =>
{
    //Search.SearchDept(departmentId);
    var DepartmentExists = (from dept in department
                            where dept.Value.DepartmentId == departmentId
                            select dept).ToList();
    if (DepartmentExists.Count == 0)
    {
        Console.WriteLine("NO SUCH RECORD FOUND");
    }
    else
    {
        var JoinQuery = (from emp in employees
                         join dept in department
                         on emp.Value.DepartmentId equals dept.Value.DepartmentId
                         select new
                         {
                             Name = emp.Value.EmployeeName,
                             id = emp.Value.DepartmentId,
                             numberofshift = emp.Value.NumberOfExtraShift,
                             basicpay=emp.Value.BasicPay
                         }).ToList();
        

        int checkNoEmployee = 0;
            foreach (var method in JoinQuery)
            {
                if (method.id == departmentId)
                {
                    checkNoEmployee++;
                    Console.WriteLine($"Employee Id: {method.id}  Employee Name: {method.Name}  Basic Pay: {method.basicpay}  Number of Shift: {method.numberofshift}  ");
                }        
            }
            if(checkNoEmployee == 0)
                Console.WriteLine("No employee in this department");
       
    }
});
bgThread.IsBackground = true;
bgThread.Start();
Console.ReadLine();




