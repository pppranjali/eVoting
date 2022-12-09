using System;
using System.Collections.Generic;

namespace Coditas.Ecom.DataAccess.Models
{
    public partial class Employee1
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public int EmployeeAge { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department1 Department { get; set; } = null!;
    }
}
