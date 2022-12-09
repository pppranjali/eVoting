using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_HM_CRUD.Entity;
using File_HM_CRUD.Model;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace File_HM_CRUD
{
    public class FileSalary:IDisposable
    {
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        Staff s;
        string filePath = string.Empty;
        string jsonString = string.Empty;

#pragma warning disable CS8618 // Non-nullable field 'sw' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'fs' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 's' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'sr' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public FileSalary()
#pragma warning restore CS8618 // Non-nullable field 'sr' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 's' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'fs' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'sw' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        {
            filePath = @"C:\Coditas_\File_HM_json\data.txt";
        }
        StaffLogic staff = new StaffLogic();
        Doctor doctor = new Doctor();
        Nurse nurse = new Nurse();
        Driver driver = new Driver();

        public void CreateFile()
        {
            try
            {
                if (filePath == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                fs = new FileStream(filePath, FileMode.OpenOrCreate);
                fs.Close(); 
                fs.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
            }
        }
        public void WriteFileDoctor(Doctor doctor)
        {
            try
            {
                if (filePath == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                string jsonString = JsonSerializer.Serialize(doctor);
                fs.Close();
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(jsonString);
                sw.Dispose();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
            }
        }
        public void WriteFileDriver(Driver driver)
        {
            try
            {
                if (filePath == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                string jsonString = JsonSerializer.Serialize(driver);
                
                fs.Close();
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(jsonString);
                sw.Dispose();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
            }
        }
        public void WriteFileNurse(Nurse nurse)
        {
            try
            {
                if (filePath == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                jsonString = JsonSerializer.Serialize(nurse);
                
                fs.Close();
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(jsonString);
                sw.Dispose();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
            }
        }

        public void ReadFile()
        {
            {
                string str = string.Empty;
                try
                {
                    Console.WriteLine("Reading file");
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string line= String.Empty;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    while ((line = sr.ReadLine()) != null)
                    {
#pragma warning disable CS8601 // Possible null reference assignment.
                        s = JsonSerializer.Deserialize<Staff>(line);
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        Console.WriteLine($"NAME::{s.StaffName}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                        Console.WriteLine(line);
                    }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    fs.Close();
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                    Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
                }
            }
        }
        public void SearchCategory(string category)
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string line;
                int exists = 0;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(category))
                    {
                        exists=1;
#pragma warning disable CS8601 // Possible null reference assignment.
                        s = JsonSerializer.Deserialize<Staff>(line);
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        Console.WriteLine($"NAME:: {s.StaffName}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    }
                }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if(exists==0)
                    Console.WriteLine("No such ID found");
                
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
            }
            
        }
        public void SearchId(string id)
        {
            {
                string str = string.Empty;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    int exists = 0;
                    string line;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(id))
                        {
#pragma warning disable CS8601 // Possible null reference assignment.
                            s = JsonSerializer.Deserialize<Staff>(line);
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                            Console.WriteLine($"NAME::{s.StaffName}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                            Console.WriteLine($"Category::{s.StaffCategory}");
                            exists = 1;
                        }
                    }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    if (exists == 0)
                    {
                        Console.WriteLine("NO SUCH ID FOUND");
                    }
                    fs.Close();
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                    Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
                }
            }
        }
        public void Count(int count)
        {
            {
                string str = string.Empty;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string line;
                    while(count!=0)
                    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                            line = sr.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'json' in 'Staff? JsonSerializer.Deserialize<Staff>(string json, JsonSerializerOptions? options = null)'.
                            s = JsonSerializer.Deserialize<Staff>(line);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'json' in 'Staff? JsonSerializer.Deserialize<Staff>(string json, JsonSerializerOptions? options = null)'.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                            Console.WriteLine($"NAME::{s.StaffName}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                            count--;   
                    }
                    fs.Close();
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
#pragma warning disable CS0162 // Unreachable code detected
                    Console.WriteLine(ex);
#pragma warning restore CS0162 // Unreachable code detected
                }
            }
        }
        public void Update(int updateId)
        {
            try
            {
                List<string> staffs = new List<string>();
                fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
                sr = new StreamReader(fs);
                sw = new StreamWriter(fs);
                string line = string.Empty;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                while((line = sr.ReadLine()) != null)
                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Staff staff = JsonSerializer.Deserialize<Staff>(line);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if(staff.StaffId==updateId)
                    {
                        if (staff.StaffCategory == "Doctor")
                        {
                            Doctor doc = new Doctor();
                            doc.StaffId = updateId;
                            doc.StaffCategory = staff.StaffCategory;
                            Console.WriteLine("Enter Name");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doc.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Education");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doc.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doc.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Specialization");
#pragma warning disable CS8601 // Possible null reference assignment.
                            doc.Specialization = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Patient per Day");
                            doc.PatientPerDay = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Basic Pay");
                            doc.BasicPay = Convert.ToInt32(Console.ReadLine());
                            staffs.Add(JsonSerializer.Serialize<Doctor>(doc));
                        }
                        else if (staff.StaffCategory == "Nurse")
                        {
                            Nurse nurse = new Nurse();
                            nurse.StaffId = updateId;
                            nurse.StaffCategory = staff.StaffCategory;
                            Console.WriteLine("Enter Name");
#pragma warning disable CS8601 // Possible null reference assignment.
                            nurse.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Education");
#pragma warning disable CS8601 // Possible null reference assignment.
                            nurse.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                            nurse.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Experience");
                            nurse.Experience = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Basic Pay");
                            nurse.BasicPay = Convert.ToInt32(Console.ReadLine());
                            staffs.Add(JsonSerializer.Serialize<Nurse>(nurse));
                        }
                        else if (staff.StaffCategory == "Driver")
                        {
                            Driver driver = new Driver();
                            driver.StaffId = updateId;
                            driver.StaffCategory = staff.StaffCategory;
                            Console.WriteLine("Enter Name");
#pragma warning disable CS8601 // Possible null reference assignment.
                            driver.StaffName = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Education");
#pragma warning disable CS8601 // Possible null reference assignment.
                            driver.Education = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Email");
#pragma warning disable CS8601 // Possible null reference assignment.
                            driver.Email = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                            Console.WriteLine("Enter Vehicle type");
                            driver.VehicleType= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Basic Pay");
                            driver.BasicPay = Convert.ToInt32(Console.ReadLine());
                            staffs.Add(JsonSerializer.Serialize<Driver>(driver));
                        }
                    }
                    else
                    {
                        staffs.Add(line);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                fs.SetLength(0);
                foreach(string s in staffs)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
                sr.Dispose();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
                    
            }
            
        }
        public void Delete(int DeleteId)
        {
            try
            {
                List<string> staffs = new List<string>();
                fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
                sr = new StreamReader(fs);
                sw = new StreamWriter(fs);
                string line = string.Empty;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                while ((line = sr.ReadLine()) != null)
                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Staff staff = JsonSerializer.Deserialize<Staff>(line);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (staff.StaffId != DeleteId)
                    {
                        staffs.Add(line);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                fs.SetLength(0);
                foreach (string s in staffs)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
                sr.Dispose();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;

            }
        }
        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
