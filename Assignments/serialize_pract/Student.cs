using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialize_pract
{
    [Serializable]
    public class Student
    {
        public int id { get; set; }
#pragma warning disable CS8618 // Non-nullable field 'name' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public string name;
#pragma warning restore CS8618 // Non-nullable field 'name' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
      
    }
}
