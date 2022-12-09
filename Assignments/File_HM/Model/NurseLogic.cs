using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_HM.Entity;

namespace File_HM.Model
{
    public class NurseLogic : StaffLogic, IDbOperations<Nurse, int>
    {
        List<Nurse> Nurses = new List<Nurse>();
        List<Nurse> IDbOperations<Nurse, int>.Create(Nurse entity)
        {
            Nurses.Add(entity);
            return Nurses;
        }
        List<Nurse> IDbOperations<Nurse, int>.Delete(int id)
        {
            int flag1 = 0;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Nurse searchNurse = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            foreach (var item in Nurses)
            {
                if (item.StaffId == id)
                {
                    searchNurse = item;
                    flag1 = 1;
                    break;
                }
            }
            if(flag1==0)
            {
                Console.WriteLine("NO SUCH RECORD FOUND!!");
            }
            else
#pragma warning disable CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Nurse>.Remove(Nurse item)'.
                Nurses.Remove(searchNurse);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Nurse>.Remove(Nurse item)'.
            return Nurses;
        }
        Nurse IDbOperations<Nurse, int>.Get(int id)
        {
            int flag = 0;
            foreach (var item in Nurses)
            {
                if (item.StaffId == id)
                {
                    flag = 1;
                    return item;
                }
            }
            if (flag == 0)
                Console.WriteLine("Id record not found");
            return new Nurse();
        }
        List<Nurse> IDbOperations<Nurse, int>.GetAll()
        {
            return Nurses;
        }
        List<Nurse> IDbOperations<Nurse, int>.Update(int id, Nurse entity)
        {
            int flag = 0;
            foreach (var item in Nurses)
            {
                if (item.StaffId == id)
                {
                    String ContinueExecution = "c";
                    flag = 1;
                    do
                    {
                        Console.WriteLine("1. To Update Name");
                        Console.WriteLine("2. To Update Email");
                        Console.WriteLine("3. To Update Contact");
                        Console.WriteLine("4. To Update Education");
                        Console.WriteLine("Enter your choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upname = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.StaffName = upname;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 2:
                                Console.WriteLine("Enter Email:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upemail = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.Email = upemail;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 3:
                                Console.WriteLine("Enter Contact:");
                                int upcontact = Convert.ToInt32(Console.ReadLine());
                                item.ContactNo = upcontact;
                                break;
                            case 4:
                                Console.WriteLine("Enter Education:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upedu = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.Education = upedu;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 5:
                                Console.WriteLine("Enter Experience:");
                                int upexp = Convert.ToInt32(Console.ReadLine());
                                item.Experience = upexp;
                                break;
                        }
                        Console.WriteLine($"-----------------------------------------------------------------");
                        Console.WriteLine($"Staff ID : {item.StaffId}");
                        Console.WriteLine($"Staff Name:{item.StaffName}");
                        Console.WriteLine($"Staff Email :{item.Email}");
                        Console.WriteLine($"Staff Education: {item.Education}");
                        Console.WriteLine($"Nurse Experience:{item.Experience}");
                        Console.WriteLine($"-----------------------------------------------------------------");
                        Console.WriteLine("To continue with next updation press c : ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        ContinueExecution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                    }while(ContinueExecution == "c");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No record found");
            }
            return Nurses;
        }
        public long GrossSalary(Nurse d)
        {
            long gross = d.BasicPay + 1000 * d.Experience;
            return gross;
        }
        public decimal Tax1(Nurse d)
        {
            decimal tax = (18 / Convert.ToDecimal(100)) * d.BasicPay;
            return tax;
        }
        public decimal HospitalShare(Nurse d)
        {
            decimal hospitalShare = (2 / Convert.ToDecimal(100)) * d.BasicPay;
            return hospitalShare;
        }
    }
}
