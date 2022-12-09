﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CS_Gen_App.Entity
{
    [Serializable]
    public class Doctor : Staff
    {
#pragma warning disable CS0108 // 'Doctor.Education' hides inherited member 'Staff.Education'. Use the new keyword if hiding was intended.
        public string Education { get; set; } = string.Empty;
#pragma warning restore CS0108 // 'Doctor.Education' hides inherited member 'Staff.Education'. Use the new keyword if hiding was intended.
        public string Specialization { get; set; } = string.Empty;
    }
}