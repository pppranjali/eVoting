using DateDifference;


Console.WriteLine("Enter start date");
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
DateTime start = DateTime.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.

Console.WriteLine("Enter end date");
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
DateTime end = DateTime.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.


Date_Diff obj1 = new Date_Diff();
obj1.get_diff(start, end);


/*
 4/8/2000 
5/8/2000
 */