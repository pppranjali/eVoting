using API_Consumer_Northwind;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;


Console.WriteLine("Consume The REST API");
Console.WriteLine("Press a Key when Service Starts");
Console.ReadLine();
HttpClient client = new HttpClient();

var custs = await client.GetFromJsonAsync<List<Customer>>("https://localhost:7280/api/Search");

foreach (var item in custs)
{
    Console.WriteLine(item.ContactName) ;
    Console.WriteLine(item.CustomerId);
}

Console.ReadLine();
