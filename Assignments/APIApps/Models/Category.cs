using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIApps.Models
{
    public partial class Category
    {
        //public Category()
        //{
        //    Products = new HashSet<Product>();
        //    SubCategories = new HashSet<SubCategory>();
        //}

        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public decimal BasePrice { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
        //public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
