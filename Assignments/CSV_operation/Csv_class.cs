using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using CsvHelper;
using CSV_operation.Entity;
using CSV_operation.Model;

namespace CSV_operation
{
    public class Csv_class
    {
        public static void FileCreate()
        {
            string DoctorPath = @"C:\Coditas_\CSV\Doctor_data.csv";
            string NursePath = @"C:\Coditas_\CSV\Nurse_data.csv";
            string DriverPath = @"C:\Coditas_\CSV\Driver_data.csv";

            using (StreamWriter sw = File.AppendText(DoctorPath))
            {
                using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<Doctor>();
                }
            }
            using (StreamWriter sw = File.AppendText(NursePath))
            {
                using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<Nurse>();
                }
            }
            using (StreamWriter sw = File.AppendText(DriverPath))
            {
                using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<Driver>();
                }
            }

        }
        public void WriteCsvDoctor(Doctor d1)
        {
                using (var writer = new StreamWriter(@"C:\Coditas_\CSV\Doctor_data.csv", append: true))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))

                {
                    csv.WriteRecord(d1);
                    writer.WriteLine();
                }   
        }
        public void WriteCsvNurse(Nurse n1)
        {
            using (var writer = new StreamWriter(@"C:\Coditas_\CSV\Nurse_data.csv", append: true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))

            {
                csv.WriteRecord(n1);
                writer.WriteLine();
            }
        }
        public void WriteCsvDriver(Driver driver)
        {
            using (var writer = new StreamWriter(@"C:\Coditas_\CSV\Doctor_data.csv", append: true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))

            {
                csv.WriteRecord(driver);
                writer.WriteLine();
            }
        }
    }
}
