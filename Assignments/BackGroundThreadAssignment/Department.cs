using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundThreadAssignment
{
    public class Department
    {
        public string DepartmentName { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
       
    }
    public class DepartmentCollection:Dictionary<int,Department>
    {
        public DepartmentCollection()
        {
            Add(1,new Department() { DepartmentName ="Dot Net",DepartmentId=1});
            Add(2,new Department() { DepartmentName ="Data Science",DepartmentId=2});
            Add(3,new Department() { DepartmentName ="Angular",DepartmentId=3});
            Add(4,new Department() { DepartmentName ="Devops",DepartmentId=4});
            Add(5,new Department() { DepartmentName ="Python",DepartmentId=5});
            Add(6,new Department() { DepartmentName ="React",DepartmentId=6});
            Add(7,new Department() { DepartmentName ="IOS",DepartmentId=7});
            Add(8,new Department() { DepartmentName ="Flutter",DepartmentId=8});

        }
    }
}
