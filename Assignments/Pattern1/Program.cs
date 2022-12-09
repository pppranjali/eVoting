using System;

class MyClass
{
    public static List<Tuple<char, int>> OrderedCount(string input)
    {
        
        List<Tuple<char, int>> list1 = new List<Tuple<char, int>>();
        for(int i=0;i<input.Length;i++)
        {
            int count = 1;
            for (int j=i+1;j<input.Length;j++)
            {
                if(input[i] == input[j])
                {
                    count++;
                }
            }
            bool tupleHadProduct = list1.Any(m => m.Item1 == input[i]);
            if(!tupleHadProduct)
            {
                list1.Add(new Tuple<char, int>(input[i], count));
            }
        }
        foreach(Tuple<char, int> tuple in list1)
        {
            Console.WriteLine(tuple);
        }
        return list1;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter String:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'input' in 'List<Tuple<char, int>> MyClass.OrderedCount(string input)'.
        List <Tuple<char,int>> output1 = OrderedCount(input);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'input' in 'List<Tuple<char, int>> MyClass.OrderedCount(string input)'.
    }
}