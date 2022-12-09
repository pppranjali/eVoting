Task t1 = Task.Factory.StartNew(() =>
{
	ReadFile();
	WriteFile();
});
//Task t2 = Task.Factory.StartNew(() => {
	
//});
Console.ReadLine();
static void ReadFile()
{
	using (StreamReader reader = new StreamReader(@"C:\Coditas_\Multitasking.txt"))
	{
		Console.WriteLine(reader.ReadToEnd());
		reader.Close();
	}
}
static void WriteFile()
{
	using (StreamWriter writer = new StreamWriter(@"C:\Coditas_\Multitasking.txt", true))
	{
		writer.WriteLine("I am new Data from Task");
		writer.Close();
	}
}