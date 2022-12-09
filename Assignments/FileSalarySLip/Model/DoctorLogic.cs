using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSalarySLip.Entity;
namespace FileSalarySLip.Model

{
    public class DoctorLogic :StaffLogic, IDbOperations<Doctor, int>
    {
        List<Doctor> Doctors = new List<Doctor>();
        List<Doctor> IDbOperations<Doctor, int>.Create(Doctor entity)
        {
            Doctors.Add(entity);
            return Doctors;
        }
        List<Doctor> IDbOperations<Doctor, int>.Delete(int id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Doctor searchDoctor = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            foreach (var item in Doctors)
            {
                if (item.StaffId == id)
                {
                    searchDoctor = item;
                    break;
                }
            }
#pragma warning disable CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Doctor>.Remove(Doctor item)'.
            Doctors.Remove(searchDoctor);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'item' in 'bool List<Doctor>.Remove(Doctor item)'.
            return Doctors;
        }
        Doctor IDbOperations<Doctor, int>.Get(int id)
        {
            int flag = 0;
            foreach (var item in Doctors)
            {
                if (item.StaffId == id)
                {
                    flag = 1;
                    return item;
                }
            }
            if (flag == 0)
                Console.WriteLine("NO SUCH ID FOUND");
            return new Doctor();
        }
        List<Doctor> IDbOperations<Doctor, int>.GetAll()
        {
            return Doctors; 
        }
        List<Doctor> IDbOperations<Doctor, int>.Update(int id, Doctor entity)
        {
            int flag = 0;
            foreach (var item in Doctors)
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
                        }
                        Console.WriteLine("To continue with next updation press c : ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        ContinueExecution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                    } while (ContinueExecution == "c");
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("No record found");
            }
            return Doctors;
                
        }
        public void Search(string name)
        {
            foreach(var d in Doctors)
            {
                if(d.StaffName==name)
                {
                    Console.WriteLine($"Search Staff Details:: ");
                    Console.WriteLine($"-----------------------------------------------------------------");
                    Console.WriteLine($"Staff ID : {d.StaffId}");
                    Console.WriteLine($"Staff Name:{d.StaffName}");
                    Console.WriteLine($"Staff Email :{d.Email}");
                    Console.WriteLine($"Staff Education: {d.Education}");
                    Console.WriteLine($"Doctor Specialization:{d.Specialization}");
                    Console.WriteLine($"-----------------------------------------------------------------");
                }
            }           
        }
        public long GrossSalary(Doctor entity)
        {
            long gross = entity.BasicPay + entity.PatientPerDay * 1000;
            return gross;
        }
        public decimal Tax1(Doctor d)
        {
            decimal tax = (18 / Convert.ToDecimal(100)) * 30000;
            return tax;
        }
        public decimal HospitalShare(Doctor d)
        {
            decimal hospitalShare = (2 / Convert.ToDecimal(100)) * 30000;
            return hospitalShare;
        }
    }
}
