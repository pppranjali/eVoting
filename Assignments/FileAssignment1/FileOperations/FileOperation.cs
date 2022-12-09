using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAssignment1.FileOperations
{
    public class FileOperation
    {
        public void CreateFile(string directory,string fileName)
        {
            try
            {
                if (Directory.Exists(directory))
                {
                    string path = $"{directory}{fileName}";
                    if (path == string.Empty)
                    {
                        throw new Exception("File Name Cannot be Empty");
                    }
                    if(File.Exists(path))
                    {
                        throw new Exception("This file already exists!!!");
                    }
                    int ind = path.IndexOf('.');
                    if (path.Substring(ind + 1) != "txt")
                    {
                        throw new Exception("INVALID FILE EXTENSION");
                    }
                    if (path.Substring(ind + 1) == "txt")
                    {
                        FileStream fs = File.Create(fileName);
                        Console.WriteLine("The File is created successfully");
                        fs.Close();
                        fs.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void WriteFile(string directory, string fileName, string contents)
        {
            try
            {
                if (Directory.Exists(directory))
                {
                    string path = $"{directory}{fileName}";
                    if (path == string.Empty)
                    {
                        throw new Exception("File Name Cannot be Empty");
                    }
                    int ind = path.IndexOf('.');
                    if (path.Substring(ind + 1) != "txt")
                    {
                        throw new Exception("INVALID FILE EXTENSION");
                    }
                    if (path.Substring(ind + 1) == "txt")
                    {
                        File.WriteAllText(path, contents);
                        Console.WriteLine("Contents are written to the File");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteFile(string directory, string fileName, string[] contents)
        {
            try
            {
                if (Directory.Exists(directory))
                {
                    string path = $"{directory}{fileName}";
                    if (path == string.Empty)
                    {
                        throw new Exception("File Name Cannot be Empty");
                    }
                    int ind = path.IndexOf('.');
                    if (path.Substring(ind + 1) != "txt")
                    {
                        throw new Exception("INVALID FILE EXTENSION");
                    }
                    if (path.Substring(ind + 1) == "txt")
                    {
                        File.WriteAllLines(path, contents);
                        Console.WriteLine("Contents are written to the File");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ReadFile(string directory, string fileName,out string contents)
        {
            try
            {
                string path = $"{directory}{fileName}";
                if (path == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                contents = File.ReadAllText(path); 
                return contents;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AppendFile(string directory, string fileName, string contents)
        {
            try
            {
                if (Directory.Exists(directory))
                {
                    string path = $"{directory}{fileName}";
                    if (path == string.Empty)
                    {
                        throw new Exception("File Name Cannot be Empty");
                    }

                    File.AppendAllText(path, contents);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AppendFile(string directory, string fileName,string[] contents)
        {
            try
            {
                string path = $"{directory}{fileName}";
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                File.AppendAllLines(path, contents);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void MakeCopy(string srcFileName, string destFileName)
        {
            if (srcFileName == string.Empty || destFileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }
            File.Copy(srcFileName, destFileName);
        }
        public void MakeMove(string srcFileName, string destFileName)
        {
            if (srcFileName == string.Empty || destFileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }
            File.Move(srcFileName, destFileName);
        }
        public void EncryptFile(string directory, string fileName)
        {
            string path = $"{directory}{fileName}";
            File.Encrypt(path);
        }
        public void DecryptFile(string directory, string fileName)
        {
            try
            {
                string path = $"{directory}{fileName}";
                File.Decrypt(path);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteFile(string directory, string fileName)
        {
            try
            {
                string path = $"{directory}{fileName}";
                File.Delete(path);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

