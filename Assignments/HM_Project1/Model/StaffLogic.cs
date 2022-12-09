using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HM_Project1.Database_DB;
using HM_Project1.Entity;

namespace HM_Project1.Model
{
    public abstract class StaffLogic
    {
        public abstract void RegisterStaff(Staff statff);
        public abstract Dictionary<int, Staff> GetStaffs();
        public abstract Dictionary<int, Staff> DeleteStaff(int id);
        
        public abstract int GetGrossIncome();
        public abstract int GetTax();
        
        public void Income(int id)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var d in HM_Project1.Database_DB.Database_HM.GlobalStaffStore)
            {
                if (id == d.Value.StaffId)
                {
                    if (d.Value.Category == "Doctor")
                    {
                        var a = (Doctor)d.Value;
                        Console.WriteLine($" Income of Staff ID: {d.Value.StaffId}  Name: {d.Value.StaffName} is: Rs.{d.Value.BasicPay + (a.Fees * a.MaxPatientsPerDay)}");
                    }
                    if (d.Value.Category == "Nurse")
                    {
                        var b = (Nurse)d.Value;
                        Console.WriteLine($" Income of Staff ID: {d.Value.StaffId}  Name: {d.Value.StaffName} is:  Rs.{d.Value.BasicPay + (b.Experience * 2)}");
                    }
                    if (d.Value.Category == "Technician")
                    {
                        var tech = (Technician)d.Value;
                        Console.WriteLine($" Income of Staff ID: {d.Value.StaffId}  Name: {d.Value.StaffName} is:  Rs.{d.Value.BasicPay + (tech.Overtime * 250)}");
                    }
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }          
        
    }

}
