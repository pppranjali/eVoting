using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace For_Parallel_Thread
{
    public class FileOperation
    {
        public static Object locked= new Object();
        public static void WriteFile(Employee em)
        {
            string ThreadName = $"{em.EmployeeId}-{em.EmployeeName}";
            try
            {
                
                Console.WriteLine($"Current Thread using the file is {ThreadName}");
                Monitor.Enter(locked);
                using (StreamWriter sw = new StreamWriter($@"C:\Coditas_\For_Parallel_thread_Assign-2\all.txt", true))
                {
                    var data = JsonSerializer.Serialize(em);
                    sw.WriteLine(data);
                }
                using (StreamWriter sw = new StreamWriter($@"C:\Coditas_\For_Parallel_thread_Assign-2\{ThreadName}.txt", true))
                {
                    sw.WriteLine("--------------Salary Slip-----------------");
                    sw.WriteLine($"Employee ID::         {em.EmployeeId}");
                    sw.WriteLine($"Employee Name::       {em.EmployeeName}");
                    sw.WriteLine($"Employee Basic Pay::  {em.BasicPay}");
                    sw.WriteLine($"Employee Salary::     {em.Salary}");
                    sw.WriteLine($"Employee Tax::        {em.Tax}");
                }
                Console.WriteLine($"File Is writte by {ThreadName}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erroc Occurred {ex.Message}");
            }
            finally
            {
               
                Monitor.Exit(locked);
            }

        }
    
    }

    public static class ProcessTax
    {
        public static Employee CalculateTax(Employee em)
        {
            int TotalPay = em.BasicPay + (50 * em.BasicPay);
            em.Tax = (18 / Convert.ToDecimal(100)) * TotalPay;
            em.Salary = TotalPay - em.Tax;
            return em;
        }

    }
}
