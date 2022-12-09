using CS_Basic_Class;

Console.WriteLine("Program Class");

Staff staff = new Staff();
StaffLogic logic = new StaffLogic();
var staffs = logic.GetAllStaff();
string continueExceution = "y";
do
{   
    Console.WriteLine("1. Insert New Staff");
    Console.WriteLine("2. Update Staff");
    Console.WriteLine("3. Get all staffs");
    Console.WriteLine("4. Delete a staff member");
    Console.WriteLine("5. Get staff information by Id");
    Console.WriteLine("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 1:
            staff = new Staff();
            Console.WriteLine("Enter the details of the new staff: ");
            Console.WriteLine("Enter Id: ");
            staff.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
#pragma warning disable CS8601 // Possible null reference assignment.
            staff.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.WriteLine("Enter Email: ");
#pragma warning disable CS8601 // Possible null reference assignment.
            staff.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.WriteLine("Enter Department: ");
#pragma warning disable CS8601 // Possible null reference assignment.
            staff.DeptName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.WriteLine("Enter Gender: ");
#pragma warning disable CS8601 // Possible null reference assignment.
            staff.Gender = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.WriteLine("Enter date of birth: ");
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
            staff.DateOfBirth = DateTime.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'DateTime DateTime.Parse(string s)'.
            Console.WriteLine("Enter Category: ");
#pragma warning disable CS8601 // Possible null reference assignment.
            staff.StaffCategory = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.WriteLine("Enter Education: ");
#pragma warning disable CS8601 // Possible null reference assignment.
            staff.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            Console.WriteLine("Enter Contact Number: ");
            staff.ContatNo = Convert.ToInt32(Console.ReadLine());
            staffs = logic.RegisterNewStaff(staff);

            foreach (var s in staffs)
            { 
                  Console.WriteLine($"ID: {s.StaffId}   Name= {s.StaffName}   Email={s.Email}   Department={s.DeptName}   Gender={s.Gender}  Date of Birth={s.DateOfBirth}  Category={s.StaffCategory}   Education={s.Education}  Contact Number={s.ContatNo}");
            }
            break;
        case 2:
            Console.WriteLine("Enter the Id you want to update:");
            int id2 = Convert.ToInt32(Console.ReadLine());
            staffs = logic.UpdateStaffInfo(id2,staff);
            foreach (var s in staffs)
            {
                Console.WriteLine($"ID: {s.StaffId}   Name= {s.StaffName}   Email={s.Email}   Department={s.DeptName}   Gender={s.Gender}   Date of Birth={s.DateOfBirth}  Category={s.StaffCategory}  Education={s.Education}   Contact Number={s.ContatNo}");
            }
            break;
        case 3:
             staffs = logic.GetAllStaff();
            foreach (var s in staffs)
            {
                Console.WriteLine($"ID: {s.StaffId} Name= {s.StaffName} Email={s.Email} Department={s.DeptName} Gender={s.Gender} Date of Birth={s.DateOfBirth} Category={s.StaffCategory} Education={s.Education} Contact Number={s.ContatNo}");
            }
            break;
        case 4:
            Console.WriteLine("Enter the Id you want to delete:");
            int id1 = Convert.ToInt32(Console.ReadLine());
            logic.DeleteStaff(id1);
            foreach (var s in staffs)
            {
                Console.WriteLine($"ID: {s.StaffId} Name= {s.StaffName} Email={s.Email} Department={s.DeptName} Gender={s.Gender} Date of Birth={s.DateOfBirth} Category={s.StaffCategory} Education={s.Education} Contact Number={s.ContatNo}");
            }
            break;
        case 5:
            Console.WriteLine("Enter the Id:");
            int id3 = Convert.ToInt32(Console.ReadLine()) ;
            staff= logic.GetStaffById(id3);
            Console.WriteLine($"Name: {staff.StaffName}");
            Console.WriteLine($"ID: {staff.StaffId}");
            Console.WriteLine($"Contact Number: {staff.ContatNo}");
            Console.WriteLine($"Education: {staff.Education}");
            Console.WriteLine($"Department: {staff.DeptName}");
            Console.WriteLine($"Gender: {staff.Gender}");
            Console.WriteLine($"Email: {staff.Email}");
            Console.WriteLine($"Birth Date : {staff.DateOfBirth}");
            Console.WriteLine($"category: {staff.StaffCategory}");
            break;

    }
    Console.WriteLine("If you want to continue press y or Y");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    continueExceution = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    Console.Clear();
}
while (continueExceution == "y" || continueExceution=="Y");   
/*
3
Pranjali
pp@gmail.com
Heart
Male
2022 6 7
Brother
MBBS
847593
*/
Console.ReadLine();