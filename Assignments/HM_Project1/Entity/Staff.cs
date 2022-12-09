using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Project1.Entity
{
    public class Staff
    { 
        public int StaffId { get; set; }
        public string StaffName { get; set; } = String.Empty;
#pragma warning disable CS8618 // Non-nullable property 'Gender' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Gender { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Gender' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Category' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Category { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Category' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Department' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Department { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Department' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Email { get; set; } = String.Empty;
        public int ContactNo { get; set; }
        public string Education { get; set; } = String.Empty;
        public int BasicPay { get; set; } 
        static public int id1 = 1;
       
    }
}
