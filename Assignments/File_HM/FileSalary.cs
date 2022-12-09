using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_HM.Entity;
using File_HM.Model;
using File_HM;
using System.Runtime.Serialization.Formatters.Binary;

namespace File_HM
{
    public class FileSalary:IDisposable
    {
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        string filePath = string.Empty;
#pragma warning disable CS8618 // Non-nullable field 'sw' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'fs' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'sr' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public FileSalary()
#pragma warning restore CS8618 // Non-nullable field 'sr' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'fs' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'sw' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        {
            filePath = @"C:\Coditas\File_HM_string\Allrecord.txt";
        }
        StaffLogic staff = new StaffLogic();
        Doctor doctor = new Doctor();
        Nurse nurse = new Nurse();
        Driver driver = new Driver();

        IDbOperations<Doctor, int> obj = new DoctorLogic();
        IDbOperations<Nurse, int> nurse1 = new NurseLogic();
        IDbOperations<Driver, int> driver1 = new DriverLogic();

        public void CreateFile()
        {
            try
            {
                if (filePath == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                fs = new FileStream(filePath,FileMode.OpenOrCreate);
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
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.Write($"ID:{doctor.StaffId} Name:{doctor.StaffName} StaffCategory:{doctor.StaffCategory} PatientPerDay:{doctor.PatientPerDay} Education:{doctor.Education} Specialization:{doctor.Specialization}\n");
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
        public void ReadFile()
        {
            {
                string str = string.Empty;
                try
                {
                    Console.WriteLine("reading file");
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string line;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
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
            {
                string str = string.Empty;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string line;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line.Contains(category))
                            Console.WriteLine(line);
                    }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
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
        public void SearchId(int id)
        {
            {
                string str = string.Empty;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    int exists=0;
                    string line;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains($"ID:{id}"))
                        {
                            Console.WriteLine(line);
                            exists = 1;
                        }
                    }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    if(exists==0)
                    {
                        Console.WriteLine("NO SUCH ID FOUND");
                    }
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
        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
