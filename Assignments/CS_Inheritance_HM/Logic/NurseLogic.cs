using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritance_HM.Module;


namespace CS_Inheritance_HM.Logic
{
    public class NurseLogic
    {
        Dictionary<int, Nurse> Nurses = new Dictionary<int, Nurse>();
       
        public Dictionary<int, Nurse> RegisterNurse(int id, Nurse nurse)
        {
            Nurses.Add(id, nurse);
            return Nurses;
        }
        public Dictionary<int, Nurse> GetAllNurse()
        {
            return Nurses;
        }
        public Dictionary<int, Nurse> UpdateNurse(int Id, Nurse nurse)
        {
            foreach (var item in Nurses.Values)
            {
                if (item.NurseID == nurse.NurseID)
                {
                    String ContinueExecution = "c";
                    do
                    {
                        Console.WriteLine("1. To Update Name");
                        Console.WriteLine("2. To Update Email");
                        Console.WriteLine("3. To Update shift start time");
                        Console.WriteLine("4. To Update shift end time");
                        Console.WriteLine("5. To Update Education");

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
                                Console.WriteLine("Enter Start Time:");
                                int starttime = Convert.ToInt32(Console.ReadLine());
                                item.ShiftStartTime = starttime;
                                break;
                            case 4:
                                Console.WriteLine("Enter End Time:");
                                int endtime = Convert.ToInt32(Console.ReadLine());
                                item.ShiftEndTime = endtime;
                                break;
                            case 5:
                                Console.WriteLine("Enter Education:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upedu = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.Education = upedu;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 6:
                                Console.WriteLine("Enter Moniter details:");
                                int moniterdetails = Convert.ToInt32(Console.ReadLine());
                                item.MoniterDetails = moniterdetails;
                                break;
                            case 7:
                                Console.WriteLine("Enter room number:");
                                int maxpatient = Convert.ToInt32(Console.ReadLine());
                                item.MoniterDetails = maxpatient;
                                break;
                        }
                        Console.WriteLine("To continue with next updation press c : ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        ContinueExecution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                    } while (ContinueExecution == "c");

                }
                else
                {
                    Console.WriteLine("Record not found!!");
                    break;
                }
            }
            return Nurses;
        }
        public Dictionary<int, Nurse> DeleteNurse(int Id)
        {
            if (Nurses.ContainsKey(Id))
            {
                Nurses.Remove(Id);
            }
            else
            {
                Console.WriteLine("No such record found!!");
            }
            return Nurses;
        }

    }
}
