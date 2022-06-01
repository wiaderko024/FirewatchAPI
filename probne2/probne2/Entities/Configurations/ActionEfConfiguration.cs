using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace probne2.Entities.Configurations;

public class ActionEfConfiguration : IEntityTypeConfiguration<Action>
{
    public void Configure(EntityTypeBuilder<Action> builder)
    {
        builder.HasKey(e => e.IdAction).HasName("Action_pk");
        builder.Property(e => e.IdAction).UseIdentityColumn();

        builder.Property(e => e.StartTime).IsRequired();
        builder.Property(e => e.EndTime);
        builder.Property(e => e.NeedSpecialEquipment).IsRequired();

        builder.ToTable("Action");
    }
}