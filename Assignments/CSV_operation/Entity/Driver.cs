using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_operation.Entity
{
    public class Driver : Staff
    {
        public int VehicleType { get; set; }
    }

    public class DriverCollection : List<Driver>
    {
        public DriverCollection()
        {
            Add(new Driver() { StaffId = 104, StaffName = "Sandesh", BasicPay = 7000, StaffCategory = "Driver",VehicleType = 1 , Email = "sandesh@gmail.com", Education = "HSC"});
            Add(new Driver() { StaffId = 105, StaffName = "Shreya", BasicPay = 5000, StaffCategory = "Driver", VehicleType = 2, Email = "shreya@gmail.com", Education = "HSC" });
            Add(new Driver() { StaffId = 106, StaffName = "Om", BasicPay = 6000, StaffCategory = "Driver", VehicleType = 2, Email = "om@gmail.com", Education = "HSC" });
            Add(new Driver() { StaffId = 107, StaffName = "Dhirva", BasicPay = 8000, StaffCategory = "Driver", VehicleType = 3, Email = "dhirva@gmail.com", Education = "HSC" });
        }
    }
}
