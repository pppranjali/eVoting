using System.IO;

string sourcePath = @"C:\Coditas_\SourceDirectory";
string targetPath = @"C:\Coditas_\TargetDirectory";

if (Directory.Exists(sourcePath))
{
    string[] files = Directory.GetFiles(sourcePath);

    foreach (string s in files)
    {

        string fileName = Path.GetFileName(s);
        string destFile = Path.Combine(targetPath, fileName);
        File.Copy(s, destFile, true);
    }
}
else
{
    Console.WriteLine("Source path does not exist!");
}
Console.WriteLine("Files copied successfully");



