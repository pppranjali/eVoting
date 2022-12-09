using System;
using System.Collections.Generic;

namespace Coditas.Ecom.DataAccess.Models
{
    public partial class Department1
    {
        public Department1()
        {
            Employee1s = new HashSet<Employee1>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual ICollection<Employee1> Employee1s { get; set; }
    }
}
