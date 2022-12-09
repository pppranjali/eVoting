using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypract1
{
    public abstract class Myclass
    {
        int count = 10;
        public  void myfun()
        { 
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"inside {count}");
                count++;
            }
        }   
        public void myfun2()
        {
            Console.WriteLine(count);
        }
    }

    public  class myClass2
    {
        public void myfun()
        {
            Console.WriteLine("child class");
        }
    }
}
