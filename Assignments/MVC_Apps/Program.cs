using Coditas.Ecom.DataAccess.Models;
using Coditas.Ecom.Repositories;
using Coditas.Ecom.Entities;
using Microsoft.EntityFrameworkCore;
using MVC_Apps.CustomFilter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<eShoppingCodiContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddScoped<IDbRepository<Category, int>, CategoryRepository>();
builder.Services.AddScoped<IDbRepository<Product, int>, ProductRepository>();
//This is used to accept the request for API and MVC Controllers
//For MVC Controllers this helps to locate View to execute
//for API we have only Addcontroller Method *******
builder.Services.AddControllersWithViews(options =>
{
    // Global REgistration of Action Filter
    options.Filters.Add(typeof(CustomException));
    // REgister the Exception Filter
    //options.Filters.Add(typeof(AppExceptionAttribute));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
{
    // Show error during Development these are standard Error Messages
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//Middleware used to read and write files on server for upload and download
//By default this is used to read contents of 'wwwroot' folder

app.UseStaticFiles();

//Create, load and execute Route table for
//MVC controller routing to execute
//an Action Method of a controller class
app.UseRouting();
//Used in case of Role Based Security
app.UseAuthorization();

//Map the incoming HTTP request URL to corresponding and the Action Method from the Controller
// {controller}/{action}/{id?}
//{Controller}: The name of the contreoller in url
//{action}: The action method from the controller mentioned in URL
//{id?}:the nullable parameter which is a scalar type variable passed to Action method
//eg:
// http://MyServer/MyApp/MyController/MyAction
// {controller}---> MyController
// {action}---> MyAction
// THe DEfault mentioned here is
// {controller} is Home
// {action} is Idnex
//{id} is optional
//when we give a controller name it is overwritten over this default controller i.e. Home

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
