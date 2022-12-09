using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritance_HM.Module;

namespace CS_Inheritance_HM.Logic
{
    public class DoctorLogic
    {
        Dictionary<int, Doctor> Doctors = new Dictionary<int, Doctor>();
        public Dictionary<int, Doctor> RegisterDoctor(int id, Doctor doctor)
        {
            Doctors.Add(id, doctor);
            return Doctors;
        }
        public Dictionary<int, Doctor> GetAllDoctor()
        {
            return Doctors;
        }
        public Dictionary<int, Doctor> DeleteDoctor(int Id)
        {
            if (Doctors.ContainsKey(Id))
            {
                Doctors.Remove(Id);
            }
            else
            {
                Console.WriteLine("No such record found!!");
            }
            return Doctors;
        }
        public Dictionary<int, Doctor> UpdateDoctor(int Id, Doctor doctor)
        {
            foreach (var item in Doctors.Values)
            {
                if (item.DoctorID == doctor.DoctorID)
                {
                    String ContinueExecution = "c";
                    do
                    {
                        Console.WriteLine("1. To Update Name");
                        Console.WriteLine("2. TO update email");
                        Console.WriteLine("3. To Update shift start time");
                        Console.WriteLine("4. To Update shift end time");
                        Console.WriteLine("5. To Update fees");
                        Console.WriteLine("6. To Update Education");
                        Console.WriteLine("7. To Update  Maximum number of patients");
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
                                Console.WriteLine("Enter End Timet:");
                                int endtime = Convert.ToInt32(Console.ReadLine());
                                item.ShiftEndTime = endtime;
                                break;
                            case 5:
                                Console.WriteLine("Enter Fees:");
                                int fees = Convert.ToInt32(Console.ReadLine());
                                item.Fees = fees;
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
                                Console.WriteLine("Enter Maximum number of patients:");
                                int maxpatient = Convert.ToInt32(Console.ReadLine());
                                item.MaxPatientsPerDay = maxpatient;
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
            return Doctors;
        }
        public Doctor GetBySpecialization(string specialization)
        {
            int flag = 0;
            Console.WriteLine("List of the specific specialization doctor::");
            foreach (var item in Doctors.Values)
            {
                if (item.Specialization == specialization)
                {
                    flag = 1;
                    Console.WriteLine(item.StaffName);
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No such specialization");
            }
#pragma warning disable CS8603 // Possible null reference return.
            return null;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
