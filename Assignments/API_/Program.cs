using Microsoft.EntityFrameworkCore;
using API_.Models;
using API_.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NorthwindContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});

builder.Services.AddScoped<IDbAccessService<Customer, int>, CustomerDataAccessService>();
builder.Services.AddScoped<IDbAccessService<Product, int>, ProductDataAccessService>();
builder.Services.AddScoped<IDbAccessService<Order, int>, OrderAccessService>();
builder.Services.AddScoped<IDbAccessService<OrderDetail, int>, OrderDetailAccessService>();


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
