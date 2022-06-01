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
        SeedDatabase(modelBuilder);
    }

    private static void SeedDatabase(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FireTruck>().HasData(new FireTruck
        {
            IdFiretruck = 1,
            OperationNumber = "1",
            SpecialEquipment = true
        }, new FireTruck
        {
            IdFiretruck = 2,
            OperationNumber = "2",
            SpecialEquipment = false
        }, new FireTruck
        {
            IdFiretruck = 3,
            OperationNumber = "3",
            SpecialEquipment = true
        });

        modelBuilder.Entity<Action>().HasData(new Action
        {
            IdAction = 1,
            StartTime = DateTime.Now,
            EndTime = DateTime.Parse("01/02/2022"),
            NeedSpecialEquipment = true
        }, new Action
        {
            IdAction = 2,
            StartTime = DateTime.Now,
            NeedSpecialEquipment = true
        });

        modelBuilder.Entity<FireTruckAction>().HasData(new FireTruckAction
        {
            IdFiretruck = 1,
            IdAction = 1,
            AssignmentDate = DateTime.Now
        }, new FireTruckAction
        {
            IdFiretruck = 2,
            IdAction = 2,
            AssignmentDate = DateTime.Now
        });
    }
}