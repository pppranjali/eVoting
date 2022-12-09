using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_EF_DbFirst.Models;
using Microsoft.EntityFrameworkCore;
namespace CS_EF_DbFirst.DataAccess
{
    internal class DepartmentDataAccess
    {
        eShoppingCodiContext _context;

        public DepartmentDataAccess()
        {
            _context = new eShoppingCodiContext();
        }

        public async Task<List<Department>> GetAsync()
        {
            return await _context.Departments.ToListAsync();
        }
        public async Task<Department> GetAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Departments.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }
        public async Task<Department> CreateAsync(Department dept)
        {
            var res = await _context.Departments.AddAsync(dept);
            await _context.SaveChangesAsync();
            return res.Entity;
        }
        //Employee emp
        public async Task<Department> UpdateAsync(int id, Department dept)
        {
            var rec = await _context.Departments.FindAsync(id);
           // var rec1 =await _context.Employees.FindAsync(id);
            if (rec != null)
            {
                // Update Individual Property
                rec.DeptName = dept.DeptName;
                rec.Location = dept.Location;
                rec.Capacity = dept.Capacity;

                //rec1.EmpName = emp.EmpName;
                //rec1.Salary = emp.Salary;
                //rec1.Designation = emp.Designation;
                //rec1.EmpNo = emp.EmpNo;
                await _context.SaveChangesAsync();
                return rec; // Modified Record
            }
            else
            {
#pragma warning disable CS8603 // Possible null reference return.
                return null;
#pragma warning restore CS8603 // Possible null reference return.
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var rec = await _context.Departments.FindAsync(id);
            if (rec != null)
            {
                _context.Departments.Remove(rec);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
