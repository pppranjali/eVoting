using FileAssignment1.FileOperations;
Console.WriteLine("Using Files");
try
{
    string fileName = @"Info.txt";
    string directory= @"C:\Coditas\Files1\";
    FileOperation operation = new FileOperation();

    operation.CreateFile(directory,fileName);
    string contents = "Contents into files";
    operation.WriteFile(directory,fileName,contents);

    var dataFromFile = operation.ReadFile(directory, fileName,out contents);

    Console.WriteLine($"Initial Data = " +
        $"{dataFromFile}");

    operation.AppendFile(directory,fileName, "The Next Data for Appended in the file");

    dataFromFile = operation.ReadFile(directory, fileName, out contents);

    Console.WriteLine($"Data After Append = " +
        $"{dataFromFile}");

    string[] data = new string[] {
      "Line 1","Line 2","Line 3","Line 4"
    };
    operation.AppendFile(directory,fileName, data);

    dataFromFile = operation.ReadFile(directory, fileName, out contents);

    Console.WriteLine($"Data After Appending Array = " +
       $"{dataFromFile}");

    //Encrypting file
    operation.EncryptFile(directory, fileName);


    //Decrypting file
    operation.DecryptFile(directory, fileName);
    operation.MakeCopy(@"C:\Coditas\Files1\Info.txt", @"C:\Coditas\Files1Copy\Copiedfile.txt");
    
    operation.MakeMove(@"C:\Coditas\Files1\Info.txt", @"C:\Coditas\Files1Copy\Copiedfile.txt");

    operation.DeleteFile(directory, fileName);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();