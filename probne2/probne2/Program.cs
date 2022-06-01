using Microsoft.EntityFrameworkCore;
using probne2.Entities;
using probne2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IActionDbService, ActionDbService>();
builder.Services.AddScoped<IFireTruckDbService, FireTruckDbService>();

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
// czy w git sposob seeduje baze (na sztywno pk)
// czy nullable pola dawac ? w dto i entity
// czy to okej endpoint do przypisania wozu?
