using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CS_Basic_Class
{
    public class StaffLogic
    {
        /// <summary>
        /// In-Memory Collection
        /// </summary>
        List<Staff> staffs;
        public StaffLogic()
        {
            // Lets have some DEfault Data
            // COllection Initializer (C# 3.0)
            staffs = new List<Staff>()
            { 
                // Object Initializer, provide the object has public properties
               new Staff() {StaffId=1,StaffName="Ajay",Email="ajay@myhosp.com", DeptName="Cancer",Gender="Male",DateOfBirth= new DateTime(1976, 8, 7),StaffCategory="Doctor",Education="MBBS",ContatNo=7747474},

               new Staff() {StaffId=2,StaffName="KIshan",Email="kishan@myhosp.com", DeptName="Heart",Gender="Male",DateOfBirth= new DateTime(1976, 9, 7),StaffCategory="Brother",Education="DMLT",ContatNo=7747499},

            };
        }

        // Public Methods or Behavior
        public List<Staff> RegisterNewStaff(Staff staff)
        {
            staffs.Add(staff);
            return staffs;
        }
        public List<Staff> UpdateStaffInfo(int id, Staff staff)
        {
            int flag = 0; 
            foreach(var item in staffs)
            {
                if(item.StaffId == id)
                {
                    String ContinueExecution = "c";
                    flag = 1;
                    do
                    {
                        Console.WriteLine("1. To Update Name");
                        Console.WriteLine("2. To Update Email");
                        Console.WriteLine("3. To Update Department");
                        Console.WriteLine("4. To Update Contact");
                        Console.WriteLine("5. To Update Gender");
                        Console.WriteLine("6. To Update Education");
                        Console.WriteLine("7. To Update Staff Category");
                        Console.WriteLine("8. To Update date of birth");
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
                                Console.WriteLine("Enter Department:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String updept = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.DeptName = updept;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 4:
                                Console.WriteLine("Enter Contact:");
                                int upcontact = Convert.ToInt32(Console.ReadLine());
                                item.ContatNo = upcontact;
                                break;
                            case 5:
                                Console.WriteLine("Enter Gender:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upgender = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.Gender = upgender;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 6:
                                Console.WriteLine("Enter Education:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upedu = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.Education = upedu;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 7:
                                Console.WriteLine("Enter Staff Category:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                String upstaffcat = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
                                item.Education = upstaffcat;
#pragma warning restore CS8601 // Possible null reference assignment.
                                break;
                            case 8:
                                Console.WriteLine("Enter date of birth:");
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
                                DateTime updob = DateTime.Parse(Console.ReadLine()); ;
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
                                item.DateOfBirth = updob;
                                break;
                        }
                        Console.WriteLine("To continue with next updation press c : ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        ContinueExecution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                    } while (ContinueExecution == "c");
                }   
            }  
            if(flag==0)
            {
                Console.WriteLine("No record found");
            }    
            return staffs;
        }
        public List<Staff> DeleteStaff(int id)
        {
            
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Staff searchefStaff = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            foreach (var item in staffs)
            {
                if (item.StaffId == id)
                {
                    searchefStaff = item;
                    break;
                }
            }
#pragma warning disable CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Staff>.Remove(Staff item)'.
            staffs.Remove(searchefStaff);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Staff>.Remove(Staff item)'.
            return staffs;
        }
        public List<Staff> GetAllStaff()
        {

            return staffs;
        }
        public Staff GetStaffById(int id)
        {
            // Search based on if if dounf return else return null
            int flag = 0;
            foreach(var item in staffs)
            {
                if(item.StaffId==id)
                {
                    flag = 1;
                    return item;

                }
            }
            if (flag == 0)
                Console.WriteLine("Id record not found");
           
                return new Staff();
      
        }
    }
}