using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Entity
{
    public class Driver : Staff
    {
#pragma warning disable CS8618 // Non-nullable property 'VehicleType' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string VehicleType { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'VehicleType' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
