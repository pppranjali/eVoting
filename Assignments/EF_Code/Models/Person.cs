using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_Code.Models
{
    public class Person
    {
        [Key]
        public int PersonUniqueId { get; set; }
        [Required]
        [StringLength(100)]
#pragma warning disable CS8618 // Non-nullable property 'PersonId' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string PersonId { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'PersonId' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        [Required]
        [StringLength(400)]
#pragma warning disable CS8618 // Non-nullable property 'PersonName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string PersonName { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'PersonName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        [Required]
        [StringLength(700)]
#pragma warning disable CS8618 // Non-nullable property 'address' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string address { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'address' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
#pragma warning disable CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Email { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Email' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
