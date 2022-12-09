DirectoryInfo di = new DirectoryInfo(@"C:\Coditas_\Directory");
DirectoryInfo[] directories = di.GetDirectories();
int count = di.GetFiles().Length;
Console.WriteLine($"Number of files in the directory are:: {count}");
FileInfo fi = new FileInfo(@"C:\Coditas_\Directory");
FileInfo[] filearray = di.GetFiles();
Console.WriteLine("-----------  DIRECTORY FILE DETAILS  ------------- ");
Console.WriteLine("File Name             File Size          Date Created              Date Modified");


foreach (FileInfo file in filearray)
{
     Console.WriteLine($"{file.Name}         {file.Length}        {file.CreationTime}           {file.LastWriteTime}");
}

Console.WriteLine("\n");
Console.WriteLine($"************* SUB-DIRECTORY FILE DETAILS  **********************");
Console.WriteLine("\n");
foreach (DirectoryInfo directory in directories){

    Console.WriteLine($"----------  File Name:: {directory.Name}  -----------");
    Console.WriteLine("File Name             File Size          Date Created              Date Modified");
    FileInfo[] files = directory.GetFiles();
    foreach (FileInfo file in files)
    {
        Console.WriteLine($"{file.Name}         {file.Length}           {file.CreationTime}           {file.LastWriteTime}");
    }   
}
