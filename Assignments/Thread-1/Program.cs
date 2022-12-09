using System.Threading;

//Thread t = new Thread(fun1);
//t.Start();
//Thread t2 = new Thread(fun2);   
//t2.Start();
class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Task t1= Task.Run(() => fun2());
        Task.WaitAll(t1);
        Task t2 = Task.Run(() => fun1());
        Console.ReadLine();
    }
    static void fun1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"In function {i}");
        }
    }
    static void fun2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"In function2 {i}");
        }
    }
}


