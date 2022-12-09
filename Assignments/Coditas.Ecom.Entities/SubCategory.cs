using System;
using System.Collections.Generic;

namespace Coditas.Ecom.Entities
{
    public partial class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; } = null!;
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
