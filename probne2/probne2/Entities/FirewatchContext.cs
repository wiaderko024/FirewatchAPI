using System.Reflection;
using Microsoft.EntityFrameworkCore;
using probne2.Entities.Configurations;

namespace probne2.Entities;

public class FirewatchContext : DbContext
{
    public virtual DbSet<FireTruck> FireTrucks { get; set; }
    public virtual DbSet<Action> Actions { get; set; }
    public virtual DbSet<FireTruckAction> FireTruckActions { get; set; }
    
    public FirewatchContext() {}
    
    public FirewatchContext(DbContextOptions<FirewatchContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FireTruckEfConfiguration).GetTypeInfo().Assembly);
    }
}