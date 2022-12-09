using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class file1:IPartial
    {
        public int add()
        {
            return 0;
        }
        public void display()
        {
            Console.WriteLine("Hello");
        }
        public void Base()
        {
            Console.WriteLine("My base class");
        }
    }
}
