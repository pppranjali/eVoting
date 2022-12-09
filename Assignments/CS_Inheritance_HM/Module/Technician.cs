using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance_HM.Module
{
    public class Technician:Staff
    {
        public Technician()
        {
           // Console.WriteLine("CTOR for Technician");
        }
        public int TechnicianID;  
        

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

