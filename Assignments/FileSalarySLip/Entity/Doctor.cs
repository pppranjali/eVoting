using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSalarySLip.Entity
{
    public class Doctor : Staff
    {
#pragma warning disable CS0108 // 'Doctor.Education' hides inherited member 'Staff.Education'. Use the new keyword if hiding was intended.
        public string Education { get; set; } = string.Empty;
#pragma warning restore CS0108 // 'Doctor.Education' hides inherited member 'Staff.Education'. Use the new keyword if hiding was intended.
        public string Specialization { get; set; } = string.Empty;
        public int PatientPerDay { get; set; }
    }
}
