using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    public abstract class Q6
    {
#pragma warning disable CS0169 // The field 'Q6.marks' is never used
        static int marks;
#pragma warning restore CS0169 // The field 'Q6.marks' is never used
        static Q6()
        {
            Console.WriteLine("Constructor");
        }
    }

}
