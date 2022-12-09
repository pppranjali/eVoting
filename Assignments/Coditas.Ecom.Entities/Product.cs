using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Coditas.Ecom.Entities
{
    public partial class Product
    {   
        public int ProductUniqueId { get; set; }
        [Required(ErrorMessage = "Product Id required")]
        public string ProductId { get; set; } = null!;
        [Required(ErrorMessage = "Product Name required")]
        public string ProductName { get; set; } = null!;
        [Required(ErrorMessage = "Description required")]

        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "Product Price required")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Category Id required")]

        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Manufacturer Id required")]

        public int ManufacturerId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Manufacturer? Manufacturer { get; set; }
        
    }
}
