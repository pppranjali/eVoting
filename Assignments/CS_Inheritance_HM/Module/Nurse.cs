using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance_HM.Module
{
    public class Nurse:Staff
    {
        public Nurse()
        {
           // Console.WriteLine("CTOR for Nurse");
        }
        public int AssignRoomNumber { get; set; }
        public int MoniterDetails { get; set; }

        public int NurseID { get; set; }
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

