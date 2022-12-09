using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class file1
    {
        public void displayconsole()
        {
            Console.WriteLine("File two");
        }
        //public void Base()
        //{
        //    Console.WriteLine("My base class");//here we are getting an error because that class is already defined in the file1 partial class
        //}
    }
}
