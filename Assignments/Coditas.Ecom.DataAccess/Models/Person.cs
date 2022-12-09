using System;
using System.Collections.Generic;

namespace Coditas.Ecom.DataAccess.Models
{
    public partial class Person
    {
        public int PersonUniqueId { get; set; }
        public string PersonId { get; set; } = null!;
        public string PersonName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
    }
}
