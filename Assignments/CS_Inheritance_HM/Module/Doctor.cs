using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance_HM.Module
{
    public class Doctor: Staff
    {
        public Doctor()
        {
           // Console.WriteLine("CTOR for Doctor");
        }
        public int DoctorID { get; set; }
        public string Specialization { get; set; } =String.Empty;
        public int Fees { get; set; }
        public int MaxPatientsPerDay { get; set; }

        public void SetBasicPay(int pay)
        {
            this.BasicPay = pay;
        }
        public int GetBasicPay()
        {
            return this.BasicPay;
        }
    }
}
