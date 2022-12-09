using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_Gen_App.Entity
{
    [Serializable]
    public class Nurse : Staff
    {
        public int Experience { get; set; }
    }
}
