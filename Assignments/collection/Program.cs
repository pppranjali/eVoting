// See https://aka.ms/new-console-template for more information
using System.Collections;
//Stack
Stack s = new Stack();
s.Push(10);
s.Push(20);
s.Push(30);
s.Pop();
Console.WriteLine("Enter the element to be inserted in the stack:");
int x = Convert.ToInt32(Console.ReadLine());
s.Push(x);

foreach(int i in s)
{
    Console.WriteLine(i);
}
//sorted list

SortedList s1 = new SortedList();
s1.Add(1, "Abhi");
s1.Add(2, "Bhumi");
s1.Add(3,"Priyanshi");
Console.WriteLine("Enter number to input in sortedlist: ");



