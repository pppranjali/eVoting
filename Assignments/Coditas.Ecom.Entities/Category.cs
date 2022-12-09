using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Coditas.Ecom.Entities
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            SubCategories = new HashSet<SubCategory>();
        }
        [Required(ErrorMessage ="Category Id required")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name required")]

        public string CategoryName { get; set; } = null!;
        [Required(ErrorMessage = "Category Base Price required")]

        public decimal BasePrice { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }

        public virtual Product? Product { get; set; }
        public virtual SubCategory? SubCategory { get; set; }
    }
}
