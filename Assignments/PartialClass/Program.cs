Singleton1 obj1 = Singleton1.MyMethod();//creating an reference to singleton class
obj1.display();
Singleton1 obj2 = Singleton1.MyMethod();
obj2.display();


int num1 = 10;
int num2 = 32;
for(int i = 0; i < num2; i++)
{
    num1++;
}
Console.WriteLine(num1);
sealed class Singleton1
{
    private  Singleton1()
    {
        
    }
    public int count = 1;
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
    public static Singleton1 Instance = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    public static Singleton1 MyMethod()
    {
        if(Instance == null)    
            return new Singleton1();
        return Instance; //method to return to return a single object every time
    }
    public  void display()

    {
        count ++;
        Console.WriteLine($"HI{count}"); //every time you will have the 2 as count because we have created only one object 
    }
}

