using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CS_EF_FirstCode.Models
{
    public class Staff
    {
        public string Name { get; set; }
        [Key]
        public int StaffId { get; set; }
        public int Salary { get; set; }
    }
    public class Doctor : Staff
    {
       
        public string Specialiazation { get; set; }
    }
    public class Nurse : Staff
    {
        
        public int RoomAllocated { get; set; }
    }
    public class WardBoy : Staff
    {
        public int floor { get; set; }
    }
}
