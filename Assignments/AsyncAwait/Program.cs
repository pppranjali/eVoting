
aprog obj = new aprog();

 obj.method3();

await obj.method1();
Console.WriteLine("Main completed");
class aprog
{
    public async Task method1()
    {
        await Task.Run(async () =>
        {
            await Task.Delay(1000);
            Console.WriteLine("method 1");
        });
    }
    //public async Task method2()
    //{
    //    await Task.Run(() =>
    //    {
    //        Console.WriteLine("method 2");
    //    });
    //}
    public void method3()
    {
        Console.WriteLine("Perform the other task till then");   
    }
}