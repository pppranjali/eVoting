class MyClass {
    static List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };
    static void Main(string[] args)
    {
        Task task = Task.Run(() => { fun1(); });
        //task.Wait();
        Task task2 = Task.Run(() => { fun2(); });
        //task2.Wait();
        Console.WriteLine("After updating the values");
        foreach (int i in myList)
        {
            Console.WriteLine(i);
        }
    }
    public static void fun1() {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("ADDING TO LIST");
            myList.Add(i);
        }
    }
    public static void fun2()
    {
       foreach (int i in myList)
        {
            Console.WriteLine($"Read from list {i} in func 2");
        }
    }
}