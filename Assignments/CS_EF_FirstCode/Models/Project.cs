using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EF_FirstCode.Models
{
    public class Project
    {
        
        public int ProjectId;
        public string ProjectName;
        public DateTime StartDate;
        public DateTime EndDate;
        public string CustomerName;
        public string Technology;
        public string ManagerName;
        public int TeamSize;
    }
}
