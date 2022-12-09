using DBConnection.Model;
using DBConnection.DataAccess;


Console.WriteLine("Using ADO.NET");
CategoryDataAccess categoryDbAccess = new CategoryDataAccess();
try
{
    var categories = categoryDbAccess.GetRecords();
    PrintData(categories);
    Console.WriteLine();
    var cat = new Category()
    {
        CategoryId = 10005,
        CategoryName = "Healthcare(Infants)",
        BasePrice = 8000
    };
    categoryDbAccess.CreateRecord(cat);
    //categoryDbAccess.UpdateRecord(cat.CategoryId,cat);
    //categoryDbAccess.DeleteRecord(cat.CategoryId);
    categories = categoryDbAccess.GetRecords();
    PrintData(categories);
}
catch (Exception ex)
{
    Console.WriteLine($"Error Occurred {ex.Message}");
}
finally
{
    categoryDbAccess.Dispose();
}
Console.ReadLine();

static void PrintData(IEnumerable<Category> categories)
{
    foreach (var cat in categories)
    {
        Console.WriteLine($"{cat.CategoryId} {cat.CategoryName} {cat.BasePrice}");
    }
}