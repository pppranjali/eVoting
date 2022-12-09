string path = @"C:\Coditas_\Paint_Image.jpg";
string destination = @"C:\Coditas_\Paint_Destination"; 

static void file(string path,string destination)
{
    Path.ChangeExtension(path, ".png");
    FileInfo fileInfo = new FileInfo(path);
    string filename = fileInfo.Name;
    fileInfo.CopyTo($@"{destination}\{filename}");
}
file(path, destination);