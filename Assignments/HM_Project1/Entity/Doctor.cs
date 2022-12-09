using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HM_Project1.Database_DB;

namespace HM_Project1.Entity
{
    public class Doctor:Staff
    {
        
        public int MaxPatientsPerDay { get; set; }
        public int Fees { get; set; }
    }
}
