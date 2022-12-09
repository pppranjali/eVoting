namespace MonitorEx
{
    class Program
    {
        static object locked = new object();
        static void Main()
        {
            Console.WriteLine("Using Monitor Object");

            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(new ThreadStart(ControlWrites));
                t.Name = $" Thread ----- {i.ToString()}";
                t.Start();
            }

            Console.ReadLine();
        }
        static void ControlWrites()
        {
            Thread.Sleep(100);
            WriteFile();
            //we have created this controlwrites just to show the delay and we can directly pass writefile to threadstart
        }
        /// Implement the SYnchronization
        static void WriteFile()
        {
            // REad the Name of the THread That will Acquire the Lock
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string ThreadName = Thread.CurrentThread.Name;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine($"Current Thread using the file is {ThreadName}");
            try
            {
                // STart The Lock Acquire
                Monitor.Enter(locked);
                using (StreamWriter sw = new StreamWriter($@"C:\Coditas_\Thread-1\MyFileSync.txt", true))
                {
                    sw.WriteLine($"The Current ENtr is From THread {ThreadName}");
                }
                Console.WriteLine($"File Is writte by {ThreadName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occurred {ex.Message}");
            }
            finally
            {
                // Releasing the Lock for the Current THread
                Monitor.Exit(locked);
            }

        }

    }



}