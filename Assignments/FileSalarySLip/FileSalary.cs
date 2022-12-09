using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSalarySLip
{
    public class FileSalary
    {
        public void CreateFile(string fileName)
        {
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                FileStream fs = File.Create(fileName);
                Console.WriteLine("The File is created successfully");
                Console.WriteLine($"File Available at :{fileName}");
                fs.Close();
                fs.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void WriteFile(string fileName, string contents)
        {
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                File.WriteAllText(fileName, contents);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string ReadFile(string fileName)
        {
            try
            {
                string contents = string.Empty;
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                contents = File.ReadAllText(fileName);
                return contents;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
