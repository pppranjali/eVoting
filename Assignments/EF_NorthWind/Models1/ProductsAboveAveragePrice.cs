using System;
using System.Collections.Generic;

namespace EF_NorthWind.Models1
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
