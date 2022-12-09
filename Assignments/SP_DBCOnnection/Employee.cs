using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DBCOnnection
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public int Salary { get; set; }
        
    }
}
