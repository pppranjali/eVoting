String[] arr=new string[] { "Mahesh", "Tejas", "Mukesh", "Satish", "Vivek","Kunal", "Vinay", "Sandeep", "Nandu", "Anil", "Abhay", "Jaywant", "Shyam", "Tushar", "Sanjay", "Sharad", "Vijay", "Abhay", "Vilas" };
Int32[] arr2=new Int32[] { 1,2,3,3,1,4,4};
string continueExecution = "y";
do
{
    Console.WriteLine("1. Sort Array length wise and reverse");
    Console.WriteLine("2. Find even and ood number index numbers");
    Console.WriteLine("3. Find Prime number index");
    Console.WriteLine("4. Print strings that contain a at any position");
    Console.WriteLine("5. Print string values starting with A,M,K");
    Console.WriteLine("6. Print Repeated strings");
    Console.WriteLine("7. Print Repeated numbers");
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
            stra();
            break;
        case 5:
            stramk(arr);
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
    Console.WriteLine("Enter size of array:");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter  values in the array");
    string[] arr = new string[size1];
    string temp = string.Empty;
    for (int i = 0; i < size1; i++)
    {
#pragma warning disable CS8601 // Possible null reference assignment.
        arr[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
    }
    
    for(int outerloop = 0;outerloop<arr.Length;outerloop++)
    {
        for (int innerloop =  0;innerloop<arr.Length-outerloop-1;innerloop++)
        {
            if (arr[innerloop].CompareTo(arr[innerloop+1])>0)
            {
                temp = arr[innerloop];
                arr[innerloop] = arr[innerloop + 1];
                arr[innerloop + 1] = temp;
            }
        }
    }
    int[] len1 = new int[arr.Length];
    string[] arr1 = new string[arr.Length];
    arr1 = arr;
    for (int i = 0; i < arr.Length; i++)
    {
        len1[i] = arr[i].Length;
    }
    Array.Sort(len1);
    int j = 0;
    Console.WriteLine("Sorting the string according the length:");

    for (int i = 0; i < arr1.Length; i++)
    {
        for (int k = i; k < arr1.Length; k++)
        {
            if (len1[j] == arr1[k].Length)
            {
                temp = arr1[i];
                arr1[i] = arr1[k];
                arr1[k] = temp;
                j++;
                break;
            }
        }
    }
    foreach (string str in arr1)
    {
        Console.WriteLine(str);
    }
    
    Console.WriteLine("Reversing the array");
    for (int i = arr1.Length-1; i >=0; i--)
    {
        Console.WriteLine(arr1[i]);
    }
}
static void eveodd()
{
    Console.WriteLine("Enter size of array:");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter values in the array:");
    int[] arr3 = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        arr3[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int ind = 0; ind < arr3.Length; ind++)
    {
        if(arr3[ind]%2==0)
        {
            Console.WriteLine($"Even number at index: {ind}");
        }
        else if(arr3[ind]%2!=0)
        {
            Console.WriteLine($"Odd number at index: {ind}");
        }

    }
}
static void primenum()
{
    Console.WriteLine("Enter size of array:");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter values in the array:");
    int[] arr3 = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        arr3[i] = Convert.ToInt32(Console.ReadLine());
    }
        for (int i = 0; i < arr3.Length; i++)
    {
        int flag = 0;
        for(int j = 2; j < arr3[i];j++)
        {
            if (arr3[i]%j==0)
            {
                flag = 1;
                break;
            }
        }
        if (flag==0)
        {
            Console.WriteLine($"Prime Number at index: {i}");
        }
    }
    
}
static void stra()
{
    Console.WriteLine("Enter the size of the array:");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter  values in the array");
    string[] arr3 = new string[size1];
    for (int i = 0; i < size1; i++)
    {
#pragma warning disable CS8601 // Possible null reference assignment.
        arr3[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
    }
    char a1 = 'a';
    Console.WriteLine("The following strings contain a in it: ");
    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i].Contains(a1))
        {
            Console.WriteLine(arr3[i]);
        }
    }
}
static void stramk(string[] arr)
{
    string alpha = "AMK";
    for (int i = 0; i < arr.Length; i++)
    {
        if (alpha.Contains(arr[i][0]))
        {
            Console.WriteLine(arr[i]);
        }
    }
}
static void repeateds()
{
    int count = 1;
    Console.WriteLine("Enter the size if array: ");
    int size1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter  values in the array");
    string[] arr2 = new string[size1];
    string[] countarr = new string[size1];
    for (int i = 0; i < size1; i++)
    {
#pragma warning disable CS8601 // Possible null reference assignment.
        arr2[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        for (int j = i + 1; j < arr2.Length; j++)
        {
            if (arr2[i] == arr2[j])
            {
                count++;
            }
        }
        if (count > 1 && !(countarr.Contains(arr2[i])))
        {
            Console.WriteLine($"The number {arr2[i]} appears {count} times in the array");
        }
        countarr[i] = arr2[i];
        count = 1;
    }

}
static void repeatedi()
{
    int count = 1;
    Console.WriteLine("Enter size of array:");
    int size1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter  values in the array");
    int[] arr2 = new int[size1];
    int[] countarr = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        arr2[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        for(int j = i+1; j < arr2.Length; j++)
        {
            if (arr2[i] == arr2[j])
            {
                count++;
            }
        }
        if(count>1 && !(countarr.Contains(arr2[i])))
        {
            Console.WriteLine($"The number {arr2[i]} appears {count} times in the array");
        }
        countarr[i] = arr2[i];
        count = 1;    
    }

}