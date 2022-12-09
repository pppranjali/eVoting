using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HM_Project1.Database_DB;


namespace HM_Project1.Entity
{
    public class Nurse:Staff
    {
        public int Experience { get; set; }
        public int AssignRoomNumber { get; set; }
    }
}
