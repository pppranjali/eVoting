using File_HM_CRUD.Entity;
using File_HM_CRUD.Model;
using File_HM_CRUD;

StaffLogic staff = new StaffLogic();
Doctor doctor = new Doctor();
Nurse nurse = new Nurse();
Driver driver = new Driver();

DoctorCollection doctorCollection = new DoctorCollection();
DriverCollection driverCollection = new DriverCollection();
NurseCollection nurseCollection = new NurseCollection();

IDbOperations<Doctor, int> obj = new DoctorLogic();
IDbOperations<Nurse, int> nurse1 = new NurseLogic();
IDbOperations<Driver, int> driver1 = new DriverLogic();

DoctorLogic dlogic = new DoctorLogic();
FileSalary operation = new FileSalary();

var Doctors = obj.GetAll();
var Nurses = nurse1.GetAll();
var Drivers = driver1.GetAll();

#pragma warning disable CS0219 // The variable 'continueExceution1' is assigned but its value is never used
string continueExceution1 = "d";
#pragma warning restore CS0219 // The variable 'continueExceution1' is assigned but its value is never used
string continueExceution = "y";
#pragma warning disable CS0219 // The variable 'continueExceution2' is assigned but its value is never used
string continueExceution2 = "n";
#pragma warning restore CS0219 // The variable 'continueExceution2' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'continueExceution3' is assigned but its value is never used
string continueExceution3 = "t";
#pragma warning restore CS0219 // The variable 'continueExceution3' is assigned but its value is never used


foreach (var l in doctorCollection)
{
    operation.CreateFile();
    operation.WriteFileDoctor(l);
}

foreach (var d in driverCollection)
{
    operation.CreateFile();
    operation.WriteFileDriver(d);
}

foreach (var n in nurseCollection)
{
    operation.CreateFile();
    operation.WriteFileNurse(n);
}
Console.WriteLine("File Created Successfully!");

do
{
    Console.WriteLine("File operations: ");
    Console.WriteLine("1. Read file");
    Console.WriteLine("2. Get Staff by Category");
    Console.WriteLine("3. Get Staff by Id");
    Console.WriteLine("4. Get Staff by count");
    Console.WriteLine("5. Update a record");
    Console.WriteLine("6. Delete a record");


    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            operation.ReadFile();
            break;
        case 2:
            string category;
            Console.WriteLine("Enter Category:: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            category = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'category' in 'void FileSalary.SearchCategory(string category)'.
            operation.SearchCategory(category);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'category' in 'void FileSalary.SearchCategory(string category)'.
            break;
        case 3:
            string searchid = string.Empty;
            Console.WriteLine("Enter ID:: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            searchid = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'id' in 'void FileSalary.SearchId(string id)'.
            operation.SearchId(searchid);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'id' in 'void FileSalary.SearchId(string id)'.
            break;
        case 4:
            int count;
            Console.WriteLine("Enter number of count records you want:: ");
            count = Convert.ToInt32(Console.ReadLine());
            operation.Count(count);
            break;
        case 5:
            int updateId;
            Console.WriteLine("Enter the ID you want to update: ");
            updateId = Convert.ToInt32(Console.ReadLine());
            operation.Update(updateId);
            break;
        case 6:
            int DeleteID;
            Console.WriteLine("Enter the ID you want to delete: ");
            DeleteID = Convert.ToInt32(Console.ReadLine());
            operation.Delete(DeleteID);
            Console.WriteLine("staff deleted succesfully");
            break;
    }
    Console.WriteLine("If you want to continue press y or Y");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    continueExceution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.Clear();
} while (continueExceution == "y" || continueExceution == "Y");
