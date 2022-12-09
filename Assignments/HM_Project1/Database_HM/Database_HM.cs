using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Project1.Database_DB
{
    public class Database_HM
    {
        public static Dictionary<int ,Staff>? GlobalStaffStore { get; set; } = new Dictionary<int, Staff>();
        public static Dictionary<int, Department> DepartmentStore { get; set; } = new Dictionary<int, Department>();
    }
}
