using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace probne2.Entities.Configurations;

public class FireTruckActionEfConfiguration : IEntityTypeConfiguration<FireTruckAction>
{
    public void Configure(EntityTypeBuilder<FireTruckAction> builder)
    {
        builder.HasKey(e => new {e.IdFiretruck, e.IdAction}).HasName("FireTruckAction_pk");

        builder.Property(e => e.AssignmentDate).IsRequired();

        builder.HasOne(e => e.FireTruck)
            .WithMany(e => e.FireTruckActions)
            .HasForeignKey(e => e.IdFiretruck)
            .HasConstraintName("FireTruckAction_FireTruck_fk")
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(e => e.Action)
            .WithMany(e => e.FireTruckActions)
            .HasForeignKey(e => e.IdAction)
            .HasConstraintName("FireTruckAction_Action_fk")
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.ToTable("FireTruck_Action");
    }
}