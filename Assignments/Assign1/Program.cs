// See https://aka.ms/new-console-template for more information
decimal x, y, z;
int flag = 0;
string ContinueExecution = "y";
do
{
    Console.WriteLine("Enter first number:");
    x = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    y = Convert.ToDecimal(Console.ReadLine());
    z = x + y;
    Console.WriteLine($"The addition result is: {z}");
    z = x - y;
    Console.WriteLine($"The substraction result is: {z}");
    z = x * y;
    Console.WriteLine($"The multiplication result is: {z}");
    z = x / y;
    Console.WriteLine($"The division result is: {z}");
    z = x * x;
    Console.WriteLine($"Square of the first number is: {z}");
    z = y * y;
    Console.WriteLine($"Square of the second number is: {z}");
    for (int i = 1; i <= y; i++)
    {
        z = x * i;
    }
    Console.WriteLine($"The Power of {x} raise to {y} is: {z}");
    for (int i = 1; i <= x / 2; i++)
    {
        if (i * i == x)
        {
            Console.WriteLine($"Square root of first number is {i}");
            flag = 1;
            break;
        }
        if (flag == 0 && (i * i) > x)
        {
            i--;
            Console.WriteLine($"Square root of first number {x} is {i}");
            break;
        }
    }
    Console.WriteLine("Press y or Y to continue: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    ContinueExecution=Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

} while (ContinueExecution == "y" || ContinueExecution == "Y");













