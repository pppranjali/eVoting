using HM_Project1.Database_DB;
using HM_Project1;

StaffLogic logic = new DoctorLogic();
DoctorLogic dlogic = new DoctorLogic();
NurseLogic nlogic = new NurseLogic();
TechnicianLogic tlogic = new TechnicianLogic();
Account account = new Account();
Department department = new Department();
Search search = new Search();

Doctor doctor = new Doctor();
Nurse nurse = new Nurse();
Staff staff = new Staff();
Technician technician = new Technician();
var Staffs = logic.GetStaffs();
string continueExceution = "y";
string continueExceution1 = "d";
string continueExceution2 = "n";
string continueExceution3 = "t";
void printfunc()
{
    
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        foreach (var d in Database_HM.GlobalStaffStore)
        {
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($"Staff ID : {d.Value.StaffId}");
            Console.WriteLine($"Staff Name:{d.Value.StaffName}");
            Console.WriteLine($"Staff Email :{d.Value.Email}");
            Console.WriteLine($"Staff Education: {d.Value.Education}");
            Console.WriteLine($"Staff Category: {d.Value.Category}");
        if (d.Value.Category == "Doctor")
        {
            var a = (Doctor)d.Value;
            
            Console.WriteLine($"Fees:{a.Fees}");
            Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");
            
        }   
        if(d.Value.Category=="Nurse")
        {
            var nur = (Nurse)d.Value;
            Console.WriteLine($"Experience: {nur.Experience}");
            Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
        }
        if(d.Value.Category == "Technician")
        {
            var tech = (Technician)d.Value;
            Console.WriteLine($"Overtime: {tech}");
        }
            Console.WriteLine($"-----------------------------------------------------------------");
    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
do
{
    Console.WriteLine("Enter the category of the staff you want to perform operations: ");
    Console.WriteLine("1. Doctor");
    Console.WriteLine("2. Nurse");
    Console.WriteLine("3. Technician");
    Console.WriteLine("4. Search based on Name");
    Console.WriteLine("5. Get income using staff Id");
    Console.WriteLine("6. Access income through Account");
    Console.WriteLine("7. Search Function");
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
                        department = new Department();
                        Console.WriteLine("Enter new doctor: ");
                        doctor.StaffId = Staff.id1;
                        doctor.Category = "Doctor";
                        doctor.BasicPay = 30000;
                        Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        doctor.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter staff Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                        doctor.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Doctor Education");
#pragma warning disable CS8601 // Possible null reference assignment.
                        doctor.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Contact details:");
                        doctor.ContactNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Doctor Fees:");
                        doctor.Fees = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter maximum number patients per day:");
                        doctor.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department Name");
#pragma warning disable CS8601 // Possible null reference assignment.
                        department.DeptName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Location:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        department.Location = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Database_HM.DepartmentStore.Add(Staff.id1, department);
                        logic.RegisterStaff(doctor);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"Department:: {department.DeptName}");
                        Console.WriteLine($"Department Loaction:: {department.Location}");
                        printfunc();
                        Staff.id1++;
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the doctor Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        dlogic.UpdateDoctor(update, doctor);
                        break;
                    case 3:
                        logic.GetStaffs();
                        printfunc();
                        break;
                    case 4:
                        Console.WriteLine("Delete Doctor Record");
                        Console.WriteLine("Enter the doctor Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        logic.DeleteStaff(deleteId);
                        logic.GetStaffs();
                        printfunc();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Education to get the list of doctors");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        string specialization = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'specialization' in 'void DoctorLogic.GetBySpecialization(string specialization)'.
                        dlogic.GetBySpecialization(specialization);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'specialization' in 'void DoctorLogic.GetBySpecialization(string specialization)'.
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
                        nurse.StaffId = Staff.id1;
                        nurse.BasicPay = 20000;
                        Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter staff Email");
                        nurse.Category = "Nurse";
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Nurse Eductation");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Contact details:");
                        nurse.ContactNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter room number assigned");
                        nurse.AssignRoomNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Nurse Experience");
                        nurse.Experience = Convert.ToInt32(Console.ReadLine());
                        logic.RegisterStaff(nurse);
                        logic.GetStaffs();
                        printfunc();
                        Staff.id1++;
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the nurse Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        nlogic.UpdateNurse(update, nurse);
                        break;
                    case 3:
                        nlogic.GetStaffs();
                        printfunc();
                        break;
                    case 4:
                        Console.WriteLine("Delete Nurse Record");
                        Console.WriteLine("Enter the nurse Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        logic.DeleteStaff(deleteId);
                        printfunc();
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
            do
            {
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
                        technician.Category = "Technician";
                        technician.StaffId = Staff.id1;
                        technician.BasicPay = 10000;
                        Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        technician.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter staff Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                        technician.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Contact details:");
                        technician.ContactNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter technician Eductation");
#pragma warning disable CS8601 // Possible null reference assignment.
                        technician.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter the number of overtime");
                        technician.Overtime = Convert.ToInt32(Console.ReadLine());
                        logic.RegisterStaff(technician);
                        printfunc();
                        Staff.id1++;
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the technician Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        tlogic.UpdateTechnician(update, technician);
                        break;
                    case 3:
                        logic.GetStaffs();
                        printfunc();
                        break;

                    case 4:
                        Console.WriteLine("Delete Technician Record");
                        Console.WriteLine("Enter the Technician Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        logic.DeleteStaff(deleteId);
                        printfunc();
                        break;

                }
                Console.WriteLine("Press t if you want to continue with technician operations: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                continueExceution3 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                Console.Clear();
            } while (continueExceution3 == "t");
            break;
        case 4:
            Console.WriteLine("Enter the name you want to search::");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string searchname = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var d in Database_HM.GlobalStaffStore)
            {
                if (d.Value.StaffName == searchname)
                {
                    Console.WriteLine($"-----------------------------------------------------------------");
                    Console.WriteLine($"Staff ID : {d.Value.StaffId}");
                    Console.WriteLine($"Staff Name:{d.Value.StaffName}");
                    Console.WriteLine($"Staff Email :{d.Value.Email}");
                    Console.WriteLine($"Staff Education: {d.Value.Education}");
                    Console.WriteLine($"Staff Category: {d.Value.Category}");
                    if (d.Value.Category == "Doctor")
                    {
                        var a = (Doctor)d.Value;

                        Console.WriteLine($"Fees:{a.Fees}");
                        Console.WriteLine($"Max Patients per day are:{a.MaxPatientsPerDay}");
                    }
                    if (d.Value.Category == "Nurse")
                    {
                        var nur = (Nurse)d.Value;
                        Console.WriteLine($"Experience: {nur.Experience}");
                        Console.WriteLine($"Room Number Assigned: {nur.AssignRoomNumber}");
                    }
                    if (d.Value.Category == "Techinicain")
                    {
                        var tech = (Technician)d.Value;
                        Console.WriteLine($"Overtime: {tech}");
                    }
                    Console.WriteLine($"-----------------------------------------------------------------");
                }

            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            break;
        case 5:
            Console.WriteLine("Enter the id you want to calculate the net income:");
            int id = Convert.ToInt32(Console.ReadLine());
            logic.Income(id);
            break;
        case 6:
            Console.WriteLine("Enter the Id of the staff you want net income:");
            int id4 = Convert.ToInt32(Console.ReadLine());
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var d in HM_Project1.Database_DB.Database_HM.GlobalStaffStore)
            {
                if (id4 == d.Value.StaffId)
                {
                    if (d.Value.Category == "Doctor")
                    {
                        logic = new DoctorLogic();
                    }
                    if (d.Value.Category == "Nurse")
                    {
                        logic = new NurseLogic();
                    }
                    if (d.Value.Category == "Technician")
                    {
                        logic = new TechnicianLogic();
                    }
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            account.GetIncome(id4, logic);
            break;
        case 7:
            string str1, str2, str3;
            Console.WriteLine("Enter the the number from the following:");
            Console.WriteLine("1.Using Staff Name");
            Console.WriteLine("2.Using Department Name");
            Console.WriteLine("3.Using Location");
            Console.WriteLine("4.Using Department Name and Location");
            Console.WriteLine("5.Using Department Name and Staff Name");
            Console.WriteLine("6.Location and Staff Name");
            Console.WriteLine("7.Using all three parameters");
            int op = Convert.ToInt32(Console.ReadLine());
            
            switch(op)
            {
                case 1:
                    Console.WriteLine("Using Staff Name");
                    Console.WriteLine("Enter the Staff Name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str3 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's0' in 'void Search.searchstaffName(string s0)'.
                    search.searchstaffName(str3);
#pragma warning restore CS8604 // Possible null reference argument for parameter 's0' in 'void Search.searchstaffName(string s0)'.
                    break;
                case 2:
                    Console.WriteLine("Using Department Name");
                    Console.WriteLine("Enter the Department:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str2 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's1' in 'void Search.searchstaffDepartment(string s1)'.
                    search.searchstaffDepartment(str2);
#pragma warning restore CS8604 // Possible null reference argument for parameter 's1' in 'void Search.searchstaffDepartment(string s1)'.
                    break;
                case 3:
                    Console.WriteLine("Using Location Name");
                    Console.WriteLine("Enter the Location:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str1 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's2' in 'void Search.searchstaffLocation(string s2)'.
                    search.searchstaffLocation(str1);
#pragma warning restore CS8604 // Possible null reference argument for parameter 's2' in 'void Search.searchstaffLocation(string s2)'.
                    break;
                case 4:
                    Console.WriteLine("Using Department and Location ");
                    Console.WriteLine("Enter the Location:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str1 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.WriteLine("Enter the Department:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str2 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's1' in 'void Search.searchstaffDepartmentLocation(string s1, string s2)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's2' in 'void Search.searchstaffDepartmentLocation(string s1, string s2)'.
                    search.searchstaffDepartmentLocation(str2,str1);
#pragma warning restore CS8604 // Possible null reference argument for parameter 's2' in 'void Search.searchstaffDepartmentLocation(string s1, string s2)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 's1' in 'void Search.searchstaffDepartmentLocation(string s1, string s2)'.
                    break;
                case 5:
                    Console.WriteLine("Using Department and Staff Name ");
                    Console.WriteLine("Enter the Department:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str2 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.WriteLine("Enter the Staff Name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str3 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's0' in 'void Search.searchstaffDepartmentStaffName(string s1, string s0)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's1' in 'void Search.searchstaffDepartmentStaffName(string s1, string s0)'.
                    search.searchstaffDepartmentStaffName(str2, str3);
#pragma warning restore CS8604 // Possible null reference argument for parameter 's1' in 'void Search.searchstaffDepartmentStaffName(string s1, string s0)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 's0' in 'void Search.searchstaffDepartmentStaffName(string s1, string s0)'.
                    break;
                case 6:
                    Console.WriteLine("Using Location and Staff Name ");
                    Console.WriteLine("Enter the Location:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str1 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.WriteLine("Enter the Staff Name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str3 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's0' in 'void Search.searchstaffLocationStaffName(string s2, string s0)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's2' in 'void Search.searchstaffLocationStaffName(string s2, string s0)'.
                    search.searchstaffLocationStaffName(str1, str3);
#pragma warning restore CS8604 // Possible null reference argument for parameter 's2' in 'void Search.searchstaffLocationStaffName(string s2, string s0)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 's0' in 'void Search.searchstaffLocationStaffName(string s2, string s0)'.
                    break;
                case 7:
                    Console.WriteLine("Using all parameters ");
                    Console.WriteLine("Enter the Location:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str1 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.WriteLine("Enter the Department:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str2 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.WriteLine("Enter the Staff Name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    str3 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's1' in 'void Search.SearchAll(string s2, string s1, string s0)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's2' in 'void Search.SearchAll(string s2, string s1, string s0)'.
#pragma warning disable CS8604 // Possible null reference argument for parameter 's0' in 'void Search.SearchAll(string s2, string s1, string s0)'.
                    search.SearchAll(str1, str2, str3);
#pragma warning restore CS8604 // Possible null reference argument for parameter 's0' in 'void Search.SearchAll(string s2, string s1, string s0)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 's2' in 'void Search.SearchAll(string s2, string s1, string s0)'.
#pragma warning restore CS8604 // Possible null reference argument for parameter 's1' in 'void Search.SearchAll(string s2, string s1, string s0)'.
                    break;
            }
            break;
    }
    Console.WriteLine("If you want to continue press y or Y");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    continueExceution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.Clear();
} while (continueExceution == "y" || continueExceution == "Y");
/*
 * Doctor
Pranjali
ppranjali@gmail.com
MBBS
345267
500
20
Cancer
Pune

Ruchika
ruchika@gmail.com
PD
728930
400
25
Heart
Mumbai

Renu
renu401@gmail.com
MBBS
527380
550
25
Heart
Mumbai

Shruti
shruti202@gmail.com
MBBS
38595
400
15
Cancer
Pune


Sangram
sangram20@gmail.com
PHD
82793
600
20
Heart
Pune
------------------------------------------------------

Priya
priya@gmail.com
Bcom
37290
203
3

Preeti
preeti@gmail.com
Bcom
73527
405
5

Shreya
shreya@gmail.com
BSC
98345
201
30

--------------------------------------------------------

Sahil
sahil201@gmail.com
63849
HSC
10


Soham
soham31@gmail.com
34577
SSC
15


Om
om211@gmail.com
45789
HSC
25

*/