using System;
class Parent
{
    public virtual void show()
    {
        Console.WriteLine("Parent");
    }
    public void PMethod()
    {
        Console.WriteLine("Parent method");
    }
}
class Child:Parent
{
    public override void show()
    {
        Console.WriteLine("Child");
    }
    public  void Cmethod()
    {
        Console.WriteLine("Child method");
    }
}
class program
{
    static void Main(string[] args)
    {
        Parent p = new Parent();
        p.show();
        Parent parent = new Child();
        Child child= new Child();
        child.show();
        parent.show();
        parent.PMethod();
    }
}