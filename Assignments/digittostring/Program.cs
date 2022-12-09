// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    String[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen","Seventeen", "Eighteen", "Nineteen" };
    String[] tens = {"","", "Twenty", "Thirty", "Forty","Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
void digittostring(int a)
    {
        int temp = a;
        int temp2=0;
        int count = 0;
        string str1=string.Empty;
        string str2 = string.Empty;
        while(temp != 0)
        {
            temp = temp / 10;
            count++;
        }
        Console.WriteLine(count);
        if (count == 1)
        {
            Console.WriteLine(units[a]);
        }
        if(count == 2)
        {
            int flag = 1;
            temp = a;
        while (temp != 0)
        {
            temp2 = temp % 10;
            if (flag == 1)
            {
                 str1=(units[temp2]);
                flag = 0;
            }
            else
            {
                 str2=(tens[temp2]);
            }
            temp = temp / 10;
        }
            Console.WriteLine($"{str2} {str1}");
        }
    }
    Console.WriteLine("enter a digit:: ");
    int dig = Convert.ToInt32(Console.ReadLine());
    digittostring(dig);

