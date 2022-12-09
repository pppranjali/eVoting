using System;
using System.Collections.Generic;

namespace CS_EF_DbFirst.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        public int ManufacturerId { get; set; }
        public string? ManufacturerName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
