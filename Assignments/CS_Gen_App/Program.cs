using CS_Gen_App.Entity;
using CS_Gen_App.Model;
StaffLogic staff = new StaffLogic();
Doctor doctor = new Doctor();
Nurse nurse = new Nurse();
Driver driver = new Driver();
IDbOperations<Doctor, int> obj = new DoctorLogic();
IDbOperations<Nurse,int> nurse1 = new NurseLogic();
IDbOperations<Driver,int> driver1 = new DriverLogic();
DoctorLogic dlogic = new DoctorLogic();
var Doctors = obj.GetAll();
var Nurses = nurse1.GetAll();
var Drivers = driver1.GetAll();
string continueExceution1 = "d";
string continueExceution = "y";
string continueExceution2 = "n";
string continueExceution3 = "t";
Staff.DocID = 1;
Staff.NurseID = 2000;
Staff.DriverID = 3000;

void docprintfunc()
{
    var docname = from doc in Doctors
                  orderby doc.StaffName ascending
                  select doc;

    foreach (var d in docname)
    {
        Console.WriteLine($"-----------------------------------------------------------------");
        Console.WriteLine($"Staff ID : {d.StaffId}");
        Console.WriteLine($"Staff Name:{d.StaffName}");
        Console.WriteLine($"Staff Email :{d.Email}");
        Console.WriteLine($"Staff Education: {d.Education}");
        Console.WriteLine($"Doctor Specialization:{d.Specialization}");
        Console.WriteLine($"-----------------------------------------------------------------");
    }
    
}
void nurseprintfunc()
{
    var nursename = from nur in Nurses
                    orderby nur.StaffName ascending
                    select nur;

    foreach (var d in nursename)
    {
        Console.WriteLine($"-----------------------------------------------------------------");
        Console.WriteLine($"Staff ID : {d.StaffId}");
        Console.WriteLine($"Staff Name:{d.StaffName}");
        Console.WriteLine($"Staff Email :{d.Email}");
        Console.WriteLine($"Nurse Contact:{d.ContactNo}");
        Console.WriteLine($"Staff Education: {d.Education}");
        Console.WriteLine($"Nurse Experience: {d.Experience}");
        Console.WriteLine($"-----------------------------------------------------------------");

    }
}
void driverprintfunc()
{
    var drivername = from driver in Drivers
                    orderby driver.StaffName ascending
                    select driver;

    foreach (var d in drivername)
    {
        Console.WriteLine($"-----------------------------------------------------------------");
        Console.WriteLine($"Staff ID : {d.StaffId}");
        Console.WriteLine($"Staff Name:{d.StaffName}");
        Console.WriteLine($"Staff Email :{d.Email}");
        Console.WriteLine($"DriverContact:{d.ContactNo}");
        Console.WriteLine($"-----------------------------------------------------------------");

    }
}
do
{
    Console.WriteLine("Enter the category of the staff you want to perform operations: ");
    Console.WriteLine("1. Doctor");
    Console.WriteLine("2. Nurse");
    Console.WriteLine("3. Driver");
    Console.WriteLine("4. Search by name");
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
                Console.WriteLine("5. Get Staff Information by ID");
                Console.WriteLine("Enter your choice: ");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        doctor = new Doctor();
                        Console.WriteLine("Enter new doctor: ");
                        doctor.StaffId=Staff.DocID;
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
                        Console.WriteLine("Enter specialization:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        doctor.Specialization = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Doctors = obj.Create(doctor);
                        Staff.DocID++;
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the doctor Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        obj.Update(update, doctor);
                        docprintfunc();
                        break;
                    case 3:
                        Doctors = obj.GetAll();
                        docprintfunc();
                        break;
                    case 4:
                        Console.WriteLine("Delete Doctor Record");
                        Console.WriteLine("Enter the doctor Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        obj.Delete(deleteId);
                        break;
                    case 5:
                        Console.WriteLine("Enter the ID: ");
                        int id1=Convert.ToInt32(Console.ReadLine()); 
                        doctor = obj.Get(id1);
                        Console.WriteLine($"Name:: {doctor.StaffName}");
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
                        nurse.StaffId = Staff.NurseID;
                        Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter staff Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Nurse Education");
#pragma warning disable CS8601 // Possible null reference assignment.
                        nurse.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Contact details:");
                        nurse.ContactNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Nurse Experience");
                        nurse.Experience = Convert.ToInt32(Console.ReadLine());
                        nurse1.Create(nurse);
                        Staff.NurseID++; 
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the nurse Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        nurse1.Update(update,nurse);
                        break;
                    case 3:
                        nurse1.GetAll();
                        nurseprintfunc();
                        break;
                    case 4:
                        Console.WriteLine("Delete Nurse Record");
                        Console.WriteLine("Enter the nurse Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        nurse1.Delete(deleteId);
                        nurseprintfunc();
                        break;
                    case 5:
                        Console.WriteLine("Enter the name you want to search::");
                       
                        
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
                Console.WriteLine("Driver CRUD operations: ");
                Console.WriteLine("1. Insert New Staff");
                Console.WriteLine("2. Update Staff");
                Console.WriteLine("3. Get all Staffs");
                Console.WriteLine("4. Delete a Staff member");
                Console.WriteLine("Enter your choice: ");
                int choice3 = Convert.ToInt32(Console.ReadLine());
                switch (choice3)
                {
                    case 1:
                        driver = new Driver();
                        driver.StaffId = Staff.DriverID;
                        Console.WriteLine("Enter new Driver ");
                        Console.WriteLine("Enter staff name:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        driver.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter staff Email:");
#pragma warning disable CS8601 // Possible null reference assignment.
                        driver.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                        Console.WriteLine("Enter Contact details:");
                        driver.ContactNo = Convert.ToInt32(Console.ReadLine());
                        driver1.Create(driver);
                        Staff.DriverID++;
                        break;
                    case 2:
                        Console.WriteLine("Update your information:");
                        Console.WriteLine("Enter the Driver Id you want to update:: ");
                        int update = Convert.ToInt32(Console.ReadLine());
                        driver1.Update(update,driver);
                        break;
                    case 3:
                        driver1.GetAll();
                        driverprintfunc();
                        break;
                    case 4:
                        Console.WriteLine("Delete Driver Record");
                        Console.WriteLine("Enter the Driver Id you want to delete:: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        driver1.Delete(deleteId);
                        break;
                }
                Console.WriteLine("Press t if you want to continue with driver operations: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                continueExceution3 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                Console.Clear();
            } while (continueExceution3 == "t");
            break;
        case 4:
            Console.WriteLine("Enter the name you want to search::");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string name1 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            int flag1 = 0;
            foreach(var d in Doctors)
            {
                if(d.StaffName==name1)
                {
                    flag1 = 1;
                    Console.WriteLine($"-----------------------------------------------------------------");
                    Console.WriteLine($"Staff ID : {d.StaffId}");
                    Console.WriteLine($"Staff Name:{d.StaffName}");
                    Console.WriteLine($"Staff Email :{d.Email}");
                    Console.WriteLine($"Staff Education: {d.Education}");
                    Console.WriteLine($"Doctor Specialization:{d.Specialization}");
                    Console.WriteLine($"-----------------------------------------------------------------");
                    break;
                }
            }
            if (flag1 == 0)
            {
                foreach (var item in Nurses)
                {
                    if (item.StaffName == name1)
                    {
                        flag1 = 1;
                        nurseprintfunc();
                        break;
                    }
                }
            }
            if (flag1 == 0)

            {
                foreach (var item in Drivers)
                {
                    if (item.StaffName == name1)
                    {
                        driverprintfunc();
                        break;
                    }
                }
            }
            break;
    }
    Console.WriteLine("If you want to continue press y or Y");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    continueExceution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.Clear();
} while (continueExceution == "y" || continueExceution == "Y");
    







