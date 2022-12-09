using CSV_operation;
using CSV_operation.Entity;
using CSV_operation.Model;

Csv_class.FileCreate();
Csv_class csv = new Csv_class();
DoctorCollection doctors = new DoctorCollection();
NurseCollection nurses = new NurseCollection();
DriverCollection drivers = new DriverCollection();
foreach (Doctor doctor in doctors)
{
    csv.WriteCsvDoctor(doctor);
}
foreach (Nurse nurse in nurses)
{
    csv.WriteCsvNurse(nurse);
}
foreach(Driver driver in drivers)
{
    csv.WriteCsvDriver(driver);
}