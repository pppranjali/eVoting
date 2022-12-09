using System;
using System.Collections.Generic;
using APIApps.CustomValidators;
namespace APIApps.Models
{
    public partial class Product
    {
        public int ProductUniqueId { get; set; }
        public string ProductId { get; set; } = null!;
        [ProductName(ErrorMessage="Product Name is Invalid")]
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }

        //public virtual Category Category { get; set; } = null!;
    }
}
