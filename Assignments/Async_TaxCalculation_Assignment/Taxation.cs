using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace Async_TaxCalculation_Assignment
{
    public class Taxation
    {
        public async Task WriteAllDataAsync(EmployeeCollection e)
        {
            try
            {
                await Task.Run(() =>
                {
                    Console.WriteLine( "In update" );
                    foreach (Employee em in e)
                    {
                        int TotalPay = em.BasicPay + (50 * em.BasicPay);
                        em.Tax = (18 / Convert.ToDecimal(100)) * TotalPay;
                        em.Salary = TotalPay - em.Tax;
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task SalarySlip(EmployeeCollection e)
        {   
            try
            {
               await Task.Run(() =>
               {
                   Console.WriteLine("In SalarySlip");
                   foreach (Employee em in e)
                   {
                       string FileName = $"{em.EmployeeId}-{em.EmployeeName}";
                       using (StreamWriter sw = new StreamWriter($@"C:\Coditas_\Async_Taxation_Assignment\{FileName}.txt", true))
                       {
                           sw.WriteLineAsync("--------------Salary Slip-----------------");
                           sw.WriteLineAsync($"Employee ID::         {em.EmployeeId}");
                           sw.WriteLineAsync($"Employee Name::       {em.EmployeeName}");
                           sw.WriteLineAsync($"Employee Basic Pay::  {em.BasicPay}");
                           sw.WriteLineAsync($"Employee Salary::     {em.Salary}");
                           sw.WriteLineAsync($"Employee Tax::        {em.Tax}");
                       }
                   }
               });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task MasterFile(EmployeeCollection e)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("In master");
                foreach (Employee em in e)
                {
                    using (StreamWriter sw = new StreamWriter($@"C:\Coditas_\Async_Taxation_Assignment\all.txt", true))
                    {
                        var data = JsonSerializer.Serialize(em);
                         sw.WriteLineAsync(data);
                    }
                }
            });
        }
        
    }
}
