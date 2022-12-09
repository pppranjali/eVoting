using System.Collections.Generic;
List <String > l1 = new List<String>();
l1.Add("Mahesh");
l1.Add("Suraj");
l1.Add("Jim");
List <int> l2 = new List<int>();
l2.Add(1);
l2.Add(2);
l2.Add(2);
string continueExecution = "y";
do
{
    Console.WriteLine("1. Sort Array length wise and reverse");
    Console.WriteLine("2. Find even and ood number index numbers");
    Console.WriteLine("3. Find Prime number index");
    Console.WriteLine("4. Print strings that contain a");
    Console.WriteLine("5. Print string values starting with A,M,K");
    Console.WriteLine("6. Print Repeated strings");
    Console.WriteLine("7. Print Repeated integers");
    Console.WriteLine("Enter your choice to perform operation");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            lensortrev();
            break;
        case 2:
            eveodd();
            break;
        case 3:
            primenum();
            break;
        case 4:
            stra(l1);
            break;
        case 5:
            stramk(l1);
            break;
        case 6:
            repeateds();
            break;
        case 7:
            repeatedi();
            break;
    }
    Console.WriteLine("Please enter y or Y to continue");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    continueExecution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.Clear();
} while (continueExecution == "y" || continueExecution == "Y");

Console.ReadLine();


static void lensortrev()
{
    Console.WriteLine("Enter size of List:");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter  values in the List");
    List<String> l1 = new List<string>();
    string temp = string.Empty;
    for (int i = 0; i < size1; i++)
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        temp = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'item' in 'void List<string>.Add(string item)'.
        l1.Add(temp);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'item' in 'void List<string>.Add(string item)'.
    }
    l1.Sort();
    List<String> l2 = new List<String>();
    List<int> len1 = new List<int>();
    l2 = l1;
    for (int i = 0; i < l1.Count; i++)
    {
        int lenn= l1[i].Length;
        len1.Add(lenn);
    }
    len1.Sort();
    int j = 0;
    Console.WriteLine("Sorting the string according the length:");

    for (int i = 0; i < l2.Count; i++)
    {
        for (int k = i;k < len1.Count;k++)
        {
            if (len1[j] == l2[k].Length)
            {
                temp=l2[i];
                l2[i] = l2[k];
                l2[k] = temp;
                j++;
                break;
            }
        }
    }
    foreach (string str in l2)
    {
        Console.WriteLine(str);
    }
    Console.WriteLine("Reversing the array");
    for (int ind = l2.Count-1; ind >=0; ind--)
    {
        Console.WriteLine(l2[ind]);
    }
    
}
static void eveodd()
{
    List<Int32> int1 = new List<Int32>();
    Console.WriteLine("Enter 5 values in the array");
    for (int i = 0; i < 5; i++)
    {
        int g = Convert.ToInt32(Console.ReadLine());
        int1.Add(g);
    }
    for (int i = 0; i < int1.Count; i++)
    {
        if (int1[i] % 2 == 0)
        {
            Console.WriteLine($"Even number at index: {i}");
        }
        else if (int1[i] % 2 != 0)
        {
            Console.WriteLine($"Odd number at index: {i}");
        }

    }
}
static void stra(List <String> l1)
{
    String a1 = "a";
    for (int i=0;i<l1.Count;i++)
    {
        if(l1[i].Contains(a1))
        {
            Console.WriteLine(l1[i]);
        }
    }
}
static void stramk(List<String> l1)
{
    foreach(string item in l1)
    {
        if (item[0]=='A' || item[0]=='M'|| item[0]=='K')
        {
            Console.WriteLine(item);
        }
    }
}
static void primenum()
{
    List <Int32> int1 = new List <Int32>();
    int1.Add(2);
    int1.Add(45);
    int1.Add(11);
    for (int i = 0; i < int1.Count; i++)
    {
        int flag = 0;
        for (int j = 2; j < int1[i]; j++)
        {
            if (int1[i] % j == 0)
            {
                flag = 1;
                break;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine($"Prime Number at index: {i}");
        }
    }

}
static void repeateds()
{
    List<String> l2 = new List<String>();
    List<string> countarr = new List<string>();
    int count = 1;
    string temp = string.Empty;
    string temp1 = string.Empty;
    Console.WriteLine("Enter the size if array: ");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter  values in the array");
    for (int i = 0; i < size1; i++)
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        temp= Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'item' in 'void List<string>.Add(string item)'.
        l2.Add(temp);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'item' in 'void List<string>.Add(string item)'.
    }
    for (int i = 0; i < l2.Count; i++)
    {
        for (int j = i + 1; j < l2.Count; j++)
        {
            if (l2[i] == l2[j])
            {
                count++;
            }
        }
        if (count > 1 && !(countarr.Contains(l2[i])))
        {
            Console.WriteLine($"The number {l2[i]} appears {count} times in the array");
        }
        countarr.Add(l2[i]);
        count = 1;
    }
    
}
static void repeatedi()
{
    List<int> l1 = new List<int>();
    int count = 1;
    Console.WriteLine("Enter 5 values in the array");
    List<int> l2 = new List<int>();
    int a = 0;
    for (int i = 0; i < 5; i++)
    {
        a = Convert.ToInt32(Console.ReadLine());
        l2.Add(a);
    }
    for (int i = 0; i < l2.Count; i++)
    {
        for (int j = i + 1; j < l2.Count; j++)
        {
            if (l2[i] == l2[j])
            {
                count++;
            }
        }
        if (count > 1 && !(l1.Contains(l2[i])))
        {
            Console.WriteLine($"The number {l2[i]} appears {count} times in the array");
        }
        l1.Add(l2[i]);
        count = 1;
    }
}