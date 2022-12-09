using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DBCOnnection
{
    public class Department
    {
        public int DeptNo { get; set; } 
#pragma warning disable CS8618 // Non-nullable property 'DeptName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string DeptName { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'DeptName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

#pragma warning disable CS8618 // Non-nullable property 'Location' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Location { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Location' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

        public int Capacity { get; set; }
        
    }
}
