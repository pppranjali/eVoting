using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_HM_CRUD.Entity
{
    
    public class Doctor : Staff
    {
#pragma warning disable CS0108 // 'Doctor.Education' hides inherited member 'Staff.Education'. Use the new keyword if hiding was intended.
        public string Education { get; set; } = string.Empty;
#pragma warning restore CS0108 // 'Doctor.Education' hides inherited member 'Staff.Education'. Use the new keyword if hiding was intended.
        public string Specialization { get; set; } = string.Empty;
        public int PatientPerDay { get; set; }
        
    }
    public class DoctorCollection : List<Doctor>
    {
        public DoctorCollection()
        {
            Add(new Doctor() { StaffId = 100, StaffName = "Madhav", BasicPay = 7000, StaffCategory = "Doctor", PatientPerDay = 16, Education = "MBBS", Specialization = "Heart" ,Email="madhav@gmail.com"});
            Add(new Doctor() { StaffId = 101, StaffName = "Pranjali", BasicPay = 5000, StaffCategory = "Doctor", PatientPerDay = 15, Education = "MBBS", Specialization = "Cancer", Email = "pp@gmail.com" });
            Add(new Doctor() { StaffId = 102, StaffName = "Ruchika", BasicPay = 6000, StaffCategory = "Doctor", PatientPerDay = 13, Education = "MBBS", Specialization = "Cancer", Email = "ruchika@gmail.com" });
            Add(new Doctor() { StaffId = 103, StaffName = "Dhirva", BasicPay = 8000, StaffCategory = "Nurse", PatientPerDay = 14, Education = "MBBS", Specialization = "Heart", Email = "dhirva@gmail.com" });
        }
    }
}