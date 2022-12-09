﻿using System;
using System.Collections.Generic;

namespace APIApp.Models
{
    public partial class Product
    {
        public int ProductUniqueId { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Descrition { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Manufacturer { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
    }
}
