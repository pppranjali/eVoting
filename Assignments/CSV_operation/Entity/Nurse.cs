using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_operation.Entity
{
    public class Nurse : Staff
    {
        public int Experience { get; set; }
    }
    public class NurseCollection : List<Nurse>
    {
        public NurseCollection()
        {
            Add(new Nurse() { StaffId = 108, StaffName = "Rishi", BasicPay = 7000, StaffCategory = "Nurse",  Email = "rishi@gmail.com", Education = "BNS",Experience = 2 });
            Add(new Nurse() { StaffId = 109, StaffName = "Priya", BasicPay = 2000, StaffCategory = "Nurse",  Email = "Priya@gmail.com", Education = "BNS",Experience = 4 });
            Add(new Nurse() { StaffId = 110, StaffName = "Santoshi", BasicPay = 4000, StaffCategory = "Nurse", Email = "santoshi@gmail.com",Education = "BNS", Experience = 1 });
            Add(new Nurse() { StaffId = 111, StaffName = "Prerna", BasicPay = 8000, StaffCategory = "Nurse", Email = "prerna@gmail.com",Education = "BNS", Experience = 3 });
        }
    }
}
