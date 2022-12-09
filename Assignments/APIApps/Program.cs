using APIApps.Models;
using APIApps.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Register the eShoppingCodeContext in DI Container
//Also provide the ConnectionString
builder.Services.AddDbContext<eShoppingCodiContext>(options =>
{
    //pass the connection string here using builder.GetConnectionString
    //this will read the "ConnectionString" section of appsetting.json
    //Configuration means it will take it from the configuration file
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});

//Register the custom Service classes in DI Container

builder.Services.AddScoped<IDbAccessService<Category, int>, CategoryDataAccessService>();
builder.Services.AddScoped<IDbAccessService<Product, int>, ProductDataAccessService>();
//builder.Services.AddScoped<IDbAccessService<Product,int>,ProductDataAccessService, IDbAccessService<Category, int>, CategoryDataAccessService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
