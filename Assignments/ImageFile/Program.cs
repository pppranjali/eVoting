using System;
using System.Drawing;
using System.IO;

Console.WriteLine("Reading Image File and getting details about it");
string filePath = @"C:\Coditas_\Image_Detail\my_image.png";
FileInfo fi = new FileInfo(filePath);
long size = fi.Length;
Console.WriteLine($"File Size in Bytes: {size}");
string fileName = fi.Name;
Console.WriteLine($"File Name: {fileName}");
string extension = fi.Extension;
Console.WriteLine($"File Extension: {extension}");

Image image= Image.FromFile(filePath);

byte[] array;
using (var ms = new MemoryStream())
{
    image.Save(ms, image.RawFormat);
    array= ms.ToArray();
}
Console.WriteLine();
foreach (byte item in array)
{
    Console.Write(item);
}

Image conversion;

Console.WriteLine("\n\nConvert to Image ");
using (MemoryStream mStream = new MemoryStream(array))
{
    conversion = Image.FromStream(mStream);
}


Console.WriteLine("Image converted"); 
string myfile = @"C:\Coditas_\Image_Detail\converion.png";
conversion.Save(myfile);
Console.WriteLine($"Image saved at {myfile}");