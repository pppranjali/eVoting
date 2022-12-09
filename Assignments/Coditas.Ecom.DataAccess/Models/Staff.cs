using System;
using System.Collections.Generic;

namespace Coditas.Ecom.DataAccess.Models
{
    public partial class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; } = null!;
        public int Salary { get; set; }
        public string Discriminator { get; set; } = null!;
        public string? Specialiazation { get; set; }
        public int? RoomAllocated { get; set; }
        public int? Floor { get; set; }
    }
}
