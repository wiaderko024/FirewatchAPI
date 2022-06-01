using Microsoft.EntityFrameworkCore;
using probne2.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<FirewatchContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

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

// bit??
// czy w dto trzeba inicjalizowac kolekcje
// te configurations przenoszenie i tworzenie wlasnych wtf?
// czy trzeba dopisywac te ktore nie maaja required max_length itp
