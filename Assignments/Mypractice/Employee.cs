using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypractice
{
    public  class Employee:IMyInterface
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public void MyInterface()
        {
            Console.WriteLine("Implemented interface");
        }
        public void MyMethod()
        {
            Console.WriteLine("Pranjali");
        }
    }
    public class Shadow:Employee
    {
        protected new int MyMethod()
        {
            Console.WriteLine("Pawar");
            return 0;
        }
    }    
    public class EmployeeCollection:List<Employee>
    {
       public EmployeeCollection()
        {
            Add(new Employee() { Id = 1,Name="pranjali" }); 
            Add(new Employee() { Id = 2,Name="Ruchika" }); 
            Add(new Employee() { Id = 3,Name="Shruti" }); 
            Add(new Employee() { Id = 4,Name="Bhavi" }); 
            Add(new Employee() { Id = 5,Name="Ali" }); 
        }
    }
}
