using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReadOperation
{
    public class ReadOperation: IDisposable
    {
        
        
            FileStream fs;
            string filePath = string.Empty;
#pragma warning disable CS8618 // Non-nullable field 'fs' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
            public ReadOperation()
#pragma warning restore CS8618 // Non-nullable field 'fs' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
            {
                filePath = @"C:\Coditas\ReadMyfile\Readfile.txt";
            }
            public string ReadFile()
            {
                string str = string.Empty;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    str = sr.ReadToEnd();
                    sr.Close();
                    sr.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return str;
            }

        public string ReadFileLine()
        {
            string str = string.Empty;
            int counter = 0;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                    counter++;
                }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                Console.WriteLine(counter);
                //str = sr.ReadLine();
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
#pragma warning disable CS8603 // Possible null reference return.
            return str;
#pragma warning restore CS8603 // Possible null reference return.
        }
        public void CharCount(int ind1,int ind2)
        {
            try
            {
                if (ind1 > ind2)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {

                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    char[] c = new char[1000];
                    sr.ReadBlock(c, ind1, ind2);

                    foreach (char c2 in c)
                    {
                        Console.Write(c2);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
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

