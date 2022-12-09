// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using CS_Inheritance_HM.Logic;
using CS_Inheritance_HM.Module;


Doctor doctor = new Doctor();
Nurse nurse = new Nurse();
Technician technician = new Technician();
DoctorLogic dlogic = new DoctorLogic();
NurseLogic nlogic = new NurseLogic();
TechnicianLogic tlogic = new TechnicianLogic();
var Doctors = dlogic.GetAllDoctor();
var Nurses = nlogic.GetAllNurse();
var Technicians = tlogic.GetAllTechnician();
string continueExceution = "y";
string continueExceution1 = "d";
string continueExceution2 = "n";
string continueExceution3 = "t";


void printfuncdoctor()
{
    foreach (var d in Doctors.Values)
    {
        Console.WriteLine($"-----------------------------------------------------------------");
        Console.WriteLine($"Staff ID : {d.StaffId}");
        Console.WriteLine($"Staff Name:{d.StaffName}");
        Console.WriteLine($"Staff Doctor ID :{d.DoctorID}");
        Console.WriteLine($"Staff Email :{d.Email}");
        Console.WriteLine($"Staff Education: {d.Education}");
        Console.WriteLine($"Staff Start time: {d.ShiftStartTime}");
        Console.WriteLine($"Staff End time:{d.ShiftEndTime}");
        Console.WriteLine($"Doctor Specialization:{d.Specialization}");
        Console.WriteLine($"Doctor fees: {d.Fees}");
        Console.WriteLine($"Maximum number of Patients :{d.MaxPatientsPerDay}");
        Console.WriteLine($"Basic Pay is:{d.BasicPay}");
        Console.WriteLine($"-----------------------------------------------------------------");
    }
    
}

void printfuncnurse()
{
    foreach (var n in Nurses.Values)
    {
        Console.WriteLine($"-----------------------------------------------------------------");
        Console.WriteLine($"Staff ID : {n.StaffId}");
        Console.WriteLine($"Staff Name:{n.StaffName}");
        Console.WriteLine($"Staff Doctor ID :{n.NurseID}");
        Console.WriteLine($"Staff Email :{n.Email}");
        Console.WriteLine($"Staff Education: {n.Education}");
        Console.WriteLine($"Staff Start time: {n.ShiftStartTime}");
        Console.WriteLine($"Staff End time:{n.ShiftEndTime}");
        Console.WriteLine($"Maximum number of Patients :{n.AssignRoomNumber}");
        Console.WriteLine($"Basic Pay is:{n.BasicPay}");
        Console.WriteLine($"-----------------------------------------------------------------");
    }
}
void printfunctechnician()
{
    foreach (var n in Technicians.Values)
    {
        Console.WriteLine($"-----------------------------------------------------------------");
        Console.WriteLine($"Staff ID : {n.StaffId}");
        Console.WriteLine($"Staff Name:{n.StaffName}");
        Console.WriteLine($"Staff Doctor ID :{n.TechnicianID}");
        Console.WriteLine($"Staff Email :{n.Email}");
        Console.WriteLine($"Staff Education: {n.Education}");
        Console.WriteLine($"Staff Start time: {n.ShiftStartTime}");
        Console.WriteLine($"Staff End time:{n.ShiftEndTime}");
        Console.WriteLine($"Basic Pay is:{n.BasicPay}");
        Console.WriteLine($"-----------------------------------------------------------------");
    }
}
do
{
    Console.WriteLine("Enter the category of the staff you want to perform operations: ");
    Console.WriteLine("1. Doctor");
    Console.WriteLine("2. Nurse");
    Console.WriteLine("3. Technician");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
            case 1:
                do
                {
                    Console.WriteLine("Doctor CRUD operations: ");
                    Console.WriteLine("1. Insert New Staff");
                    Console.WriteLine("2. Update Staff");
                    Console.WriteLine("3. Get all Staffs");
                    Console.WriteLine("4. Delete a Staff member");
                    Console.WriteLine("5. Get Staff Information by Specialization");
                    Console.WriteLine("Enter your choice: ");
                    int choice1 = Convert.ToInt32(Console.ReadLine());

                    switch (choice1)
                    {
                        case 1:
                            doctor = new Doctor();
                            Console.WriteLine("Enter new doctor: ");
                            Console.WriteLine("Enter Staff ID ");
                            doctor.StaffId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter doctor ID");
                            doctor.DoctorID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doctor.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter staff Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doctor.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Doctor Eductation");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doctor.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Shift Start time:");
                            doctor.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Shift Start time:");
                            doctor.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter doctor Specialization");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doctor.Specialization = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Doctor Fees:");
                            doctor.Fees = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter maximum number patients per day:");
                            doctor.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Basic Pay");
                            doctor.SetBasicPay(Convert.ToInt32(Console.ReadLine()));
                            Doctors = dlogic.RegisterDoctor(doctor.DoctorID, doctor);
                            printfuncdoctor();
                            break;
                        case 2:
                            Console.WriteLine("Update your information:");
                            Console.WriteLine("Enter the doctor Id you want to update:: ");
                            int update = Convert.ToInt32(Console.ReadLine());
                            dlogic.UpdateDoctor(update, doctor);
                            break;
                        case 3:
                            Doctors = dlogic.GetAllDoctor();
                            printfuncdoctor();
                            break;

                        case 4:
                            Console.WriteLine("Delete Doctor Record");
                            Console.WriteLine("Enter the doctor Id you want to delete:: ");
                            int deleteId = Convert.ToInt32(Console.ReadLine());
                            dlogic.DeleteDoctor(deleteId);
                            printfuncdoctor();
                            break;

                        case 5:
                            Console.WriteLine("Enter the Specialization to get the list of doctors");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                            string specialization = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'specialization' in 'Doctor DoctorLogic.GetBySpecialization(string specialization)'.
                            doctor = dlogic.GetBySpecialization(specialization);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'specialization' in 'Doctor DoctorLogic.GetBySpecialization(string specialization)'.
                            break;
                    }
                    Console.WriteLine("Press d if you want to continue with doctor operations: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    continueExceution1 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Clear();
                } while (continueExceution1 == "d");
            break;
            
    case 2:
            do 
            { 
                Console.WriteLine("Nurse CRUD operations: ");
                Console.WriteLine("1. Insert New Staff");
                Console.WriteLine("2. Update Staff");
                Console.WriteLine("3. Get all Staffs");
                Console.WriteLine("4. Delete a Staff member");
                Console.WriteLine("Enter your choice: ");
                int choice2 = Convert.ToInt32(Console.ReadLine());

                switch (choice2)
                { 
                    case 1:
                        nurse = new Nurse();
                        Console.WriteLine("Enter new nurse: ");
                        Console.WriteLine("Enter Staff ID ");
                        nurse.StaffId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter nurse ID");
                        nurse.NurseID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter staff Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Nurse Eductation");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Shift Start time:");
                        nurse.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Shift Start time:");
                        nurse.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number of patients to be monitered in a day:");
                        nurse.MoniterDetails = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter room number assigned");
                        nurse.AssignRoomNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Basic Pay");
                        nurse.SetBasicPay(Convert.ToInt32(Console.ReadLine()));
                        Nurses = nlogic.RegisterNurse(nurse.NurseID, nurse);
                        printfuncnurse();
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the nurse Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        nlogic.UpdateNurse(update, nurse);
                        break;
                    case 3:
                        Nurses = nlogic.GetAllNurse();
                        printfuncnurse();
                        break;
                    case 4:
                        Console.WriteLine("Delete Nurse Record");
                        Console.WriteLine("Enter the nurse Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        nlogic.DeleteNurse(deleteId);
                        printfuncnurse();
                        break;
                }
                
            Console.WriteLine("Press n if you want to continue with nurse operations: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            continueExceution2 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.Clear();
            } while (continueExceution2 == "n");
            break;
    case 3:
            do { 
                Console.WriteLine("Technician CRUD operations: ");
                Console.WriteLine("1. Insert New Staff");
                Console.WriteLine("2. Update Staff");
                Console.WriteLine("3. Get all Staffs");
                Console.WriteLine("4. Delete a Staff member");
                Console.WriteLine("Enter your choice: ");
                int choice3 = Convert.ToInt32(Console.ReadLine());

                switch (choice3)
                {
                    case 1:
                        technician = new Technician();
                        Console.WriteLine("Enter new technician: ");
                        Console.WriteLine("Enter Staff ID ");
                        technician.StaffId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter technician ID");
                        technician.TechnicianID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        technician.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter staff Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                        technician.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter technician Eductation");
#pragma warning disable CS8601 // Possible null reference assignment.
                        technician.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Shift Start time:");
                        technician.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Shift Start time:");
                        technician.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Basic Pay");
                        technician.SetBasicPay(Convert.ToInt32(Console.ReadLine()));
                        Technicians = tlogic.RegisterTechnician(technician.TechnicianID, technician);
                        printfuncdoctor();
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the technician Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        tlogic.UpdateTechnician(update, technician);
                        break;
                    case 3:
                        Technicians = tlogic.GetAllTechnician();
                        printfunctechnician();
                        break;

                    case 4:
                        Console.WriteLine("Delete Technician Record");
                        Console.WriteLine("Enter the Technician Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        tlogic.DeleteTechnician(deleteId);
                        printfunctechnician();
                        break;

                }
                Console.WriteLine("Press t if you want to continue with technician operations: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                continueExceution3 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                Console.Clear();
            } while (continueExceution3 == "t");
            break;
    }
    Console.WriteLine("If you want to continue press y or Y");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    continueExceution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.Clear();
}while(continueExceution == "y" || continueExceution == "Y"); 


/*

Pranjali
pp@gmail
mbbs
1
6
Cancer
400
40
4000



Priya
pri@gmail
pd
3
9
Heart
500
50
5000

3
300
Ranbir 
ranbir@gmail.com
mbbs
10
6
Cancer
250
45
3000


--------------------------------------------------------------------------------------
4
400
priya
priya@gmail.com

*/