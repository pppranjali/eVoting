using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HM_Project1.Model
{
    public class NurseLogic : StaffLogic
    {
        public override void RegisterStaff(Staff staff)
        {
            if (Database_DB.Database_HM.GlobalStaffStore != null)
            {
                Database_DB.Database_HM.GlobalStaffStore.Add(Staff.id1,staff);
            }
        }
        public override Dictionary<int,Staff> GetStaffs()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return Database_DB.Database_HM.GlobalStaffStore;
#pragma warning restore CS8603 // Possible null reference return.
        }
        public override Dictionary<int, Staff> DeleteStaff(int id)
        {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (Database_DB.Database_HM.GlobalStaffStore.ContainsKey(id))
            {
                Database_DB.Database_HM.GlobalStaffStore.Remove(id);
            }
            else
            {
                Console.WriteLine("No such record found!!");
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            return Database_DB.Database_HM.GlobalStaffStore;
        }
        public void UpdateNurse(int id, Nurse n)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var staff in Database_DB.Database_HM.GlobalStaffStore)
            {
                var nurse1 = (Nurse)staff.Value;
                if (staff.Value.StaffId == id)
                {
                    String ContinueExecution = "c";
                    do
                    {
                        Console.WriteLine("1. To Update Name");
                        Console.WriteLine("2. TO update Email");
                        Console.WriteLine("3. To update the room number assigned");
                        Console.WriteLine("4. To Update Education");
                        Console.WriteLine("5. TO update contact number");

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
                                staff.Value.StaffName = upname;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 2:
                                Console.WriteLine("Enter Email:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upemail = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                staff.Value.Email = upemail;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 3:
                                Console.WriteLine("Enter Room number:");
                                int uproom = Convert.ToInt32(Console.ReadLine());
                                nurse1.AssignRoomNumber = uproom;
                                break;
                            case 4:
                                Console.WriteLine("Enter Education:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upedu = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                staff.Value.Education = upedu;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 5:
                                Console.WriteLine("Enter Contact number");
                                int upnum = Convert.ToInt32(Console.ReadLine());
                                staff.Value.ContactNo = upnum;
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
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        public override int GetGrossIncome()
        {
            return 15000;
        }
        public override int GetTax()
        {
            return (3600);
        }
        
    }
}
