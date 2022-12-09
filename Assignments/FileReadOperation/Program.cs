// See https://aka.ms/new-console-template for more information
using FileReadOperation;

Console.WriteLine("Using Stream");
ReadOperation operation = new ReadOperation();
try
{
    Console.WriteLine("Reading the file line by line");
    string str1 = operation.ReadFileLine();
    Console.WriteLine(str1);
    Console.WriteLine("==================================================================");


    Console.WriteLine("Reading the entire file");
    string str = operation.ReadFile();
    Console.WriteLine(str);
    Console.WriteLine("==================================================================");


    Console.WriteLine("Reading particlar characters");
    Console.WriteLine("Enter start index: ");
    int id1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter start index: ");
    int id2 = Convert.ToInt32(Console.ReadLine());
    operation.CharCount(id1,id2);

    Console.WriteLine("==================================================================");

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    operation.Dispose();
}
Console.ReadLine();