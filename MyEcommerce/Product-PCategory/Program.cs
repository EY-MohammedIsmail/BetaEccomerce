using Microsoft.EntityFrameworkCore;
using Product_PCategory.DataAccess;
using Product_PCategory.Repository;
using MediatR;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));
builder.Services.AddScoped<ICategory, CategoryRepo>();
builder.Services.AddMediatR(typeof(CategoryRepo).Assembly);
builder.Services.AddScoped<IProduct, ProductRepo>();
builder.Services.AddMediatR(typeof(ProductRepo).Assembly);
//Add Service for JSON-Serializer
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});





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
