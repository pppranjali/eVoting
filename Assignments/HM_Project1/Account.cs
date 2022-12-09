using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HM_Project1.Model;
namespace HM_Project1
{
    public class Account
    {
        DoctorLogic doc = new DoctorLogic();
        NurseLogic nurse = new NurseLogic();
        TechnicianLogic tech = new TechnicianLogic();

        public void GetIncome(int id,StaffLogic logic)
        {   
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var d in Database_HM.GlobalStaffStore)
            {
                if (id == d.Value.StaffId)
                {
                    int g = logic.GetTax();
                    Console.WriteLine($"NET INCOME of given ID {d.Value.StaffId} :: {(d.Value.BasicPay-g)*12}");
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
