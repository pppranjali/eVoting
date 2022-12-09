using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace Thread_File_Sync
{
    public class FileOperation
    {
        public static Object locked= new Object();
        public static void WriteFile(Employee em)
        {
            // Read the Name of the Thread That will Acquire the Lock
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string ThreadName = Thread.CurrentThread.Name;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            try
            {
                
                    int TotalPay = em.BasicPay + (50 * em.BasicPay);
                    em.Tax = (18 / Convert.ToDecimal(100)) * TotalPay;
                    em.Salary = TotalPay - em.Tax;
                
                // Start The Lock Acquire
                Console.WriteLine($"Current Thread using the file is {ThreadName}");
                Monitor.Enter(locked);
                using (StreamWriter sw = new StreamWriter($@"C:\Coditas_\ThreadAssignment-1\all.txt", true))
                {
                    var data = JsonSerializer.Serialize(em);
                    sw.WriteLine(data);
                }
                using (StreamWriter sw = new StreamWriter($@"C:\Coditas_\ThreadAssignment-1\{ThreadName}.txt", true))
                {
                    sw.WriteLine("--------------Salary Slip-----------------");
                    sw.WriteLine($"Employee ID::         {em.EmployeeId}");
                    sw.WriteLine($"Employee Name::       {em.EmployeeName}");
                    sw.WriteLine($"Employee Basic Pay::  {em.BasicPay}");
                    sw.WriteLine($"Employee Salary::     {em.Salary}");
                    sw.WriteLine($"Employee Tax::        {em.Tax}");
                }
                Console.WriteLine($"File Is written by {ThreadName}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occurred {ex.Message}");
            }
            finally
            {
                // Releasing the Lock for the Current Thread
                Monitor.Exit(locked);
            }

        }
    
    }
}
