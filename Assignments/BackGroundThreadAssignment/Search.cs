using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundThreadAssignment
{
    public class Search
    {        
        public static void SearchDept(int departmentId)
        {
            DepartmentCollection department = new DepartmentCollection();
            EmployeeCollection employees = new EmployeeCollection();
            var DepartmentExists = (from dept in department
                                    where dept.Value.DepartmentId == departmentId
                                    select dept).ToList();
            if (DepartmentExists.Count == 0)
            {
                Console.WriteLine("No such dept found");
            }
            else
            {
                var MethodQuery = (from emp in employees
                                   join dept in department
                                   on emp.Value.DepartmentId equals dept.Value.DepartmentId
                                   select new
                                   {
                                       Name = emp.Value.EmployeeName,
                                       id = dept.Value.DepartmentId
                                   }).ToList();

                foreach (var method in MethodQuery)
                {
                    if (method.id == departmentId)
                        Console.WriteLine(method.Name);
                }
            }
        }
    }
}
