using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_EF_DbFirst.Models;
using Microsoft.EntityFrameworkCore;
namespace CS_EF_DbFirst.DataAccess
{
    internal class EmployeeDataAccess
    {
        eShoppingCodiContext context;

        public EmployeeDataAccess()
        {
            context = new eShoppingCodiContext();
        }

        public async Task<List<Employee>> GetDataAsync()
        {
            var emps = await context.Employees.ToListAsync();
            return emps;
        }

        public List<Employee> GetDataLINQSync()
        {
            var emps = (from emp in context.Employees
                        select emp);

            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpNo);
            }

#pragma warning disable CS8603 // Possible null reference return.
            return null;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<List<Employee>> GetDataLINQAsync()
        {
            var emps = (from emp in context.Employees
                        select emp).ToListAsync();

            var result = await emps;

            foreach (var item in result)
            {
                Console.WriteLine(item.EmpNo);
            }

            return result;
        }
        public async Task<List<Employee>> GetDataLINQOrderByAsync()
        {
            var emps = (from emp in context.Employees
                        orderby emp.EmpName
                        select emp).ToListAsync();
            return await emps;
        }
    }
}