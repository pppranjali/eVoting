using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using API_Consumer;

Console.WriteLine("Consume The REST API");
Console.WriteLine("Press a Key when Service Starts");
Console.ReadLine();
HttpClient client = new HttpClient();

var cats = await client.GetFromJsonAsync<List<Category>>("https://localhost:7191/api/Category");

foreach (var item in cats)
{
    Console.WriteLine($"{item.CategoryId} {item.CategoryName} {item.BasePrice}");
}

Console.WriteLine("POST");
var catNew = new Category()
{
    CategoryId = 1012,
    CategoryName = "Travel",
    BasePrice = 4444
};
var response = await client.PostAsJsonAsync<Category>("https://localhost:7191/api/Category", catNew);
//resonse.Content, will return HttpContext Object
//response.Content.ReadAsStringAsync(), will provde actual Details in Response Message
Console.WriteLine(await response.Content.ReadAsStringAsync());

//var response1 = await client.PutAsJsonAsync<Category>($"https://localhost:7191/api/Category/{catNew.CategoryId}", catNew);

//var response2 = await client.DeleteAsync($"https://localhost:7191/api/Category/{catNew.CategoryId}");


Console.ReadLine();
