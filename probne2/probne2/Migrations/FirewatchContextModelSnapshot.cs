// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using probne2.Entities;

#nullable disable

namespace probne2.Migrations
{
    [DbContext(typeof(FirewatchContext))]
    partial class FirewatchContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("probne2.Entities.Action", b =>
                {
                    b.Property<int>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAction"), 1L, 1);

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NeedSpecialEquipment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAction")
                        .HasName("Action_pk");

                    b.ToTable("Action", (string)null);

                    b.HasData(
                        new
                        {
                            IdAction = 1,
                            EndTime = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NeedSpecialEquipment = true,
                            StartTime = new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2430)
                        },
                        new
                        {
                            IdAction = 2,
                            NeedSpecialEquipment = true,
                            StartTime = new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2610)
                        });
                });

            modelBuilder.Entity("probne2.Entities.FireTruck", b =>
                {
                    b.Property<int>("IdFiretruck")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFiretruck"), 1L, 1);

                    b.Property<string>("OperationNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("SpecialEquipment")
                        .HasColumnType("bit");

                    b.HasKey("IdFiretruck")
                        .HasName("FireTruck_pk");

                    b.ToTable("FireTruck", (string)null);

                    b.HasData(
                        new
                        {
                            IdFiretruck = 1,
                            OperationNumber = "1",
                            SpecialEquipment = true
                        },
                        new
                        {
                            IdFiretruck = 2,
                            OperationNumber = "2",
                            SpecialEquipment = false
                        },
                        new
                        {
                            IdFiretruck = 3,
                            OperationNumber = "3",
                            SpecialEquipment = true
                        });
                });

            modelBuilder.Entity("probne2.Entities.FireTruckAction", b =>
                {
                    b.Property<int>("IdFiretruck")
                        .HasColumnType("int");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.Property<DateTime>("AssignmentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdFiretruck", "IdAction")
                        .HasName("FireTruckAction_pk");

                    b.HasIndex("IdAction");

                    b.ToTable("FireTruck_Action", (string)null);

                    b.HasData(
                        new
                        {
                            IdFiretruck = 1,
                            IdAction = 1,
                            AssignmentDate = new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2690)
                        },
                        new
                        {
                            IdFiretruck = 2,
                            IdAction = 2,
                            AssignmentDate = new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2690)
                        });
                });

            modelBuilder.Entity("probne2.Entities.FireTruckAction", b =>
                {
                    b.HasOne("probne2.Entities.Action", "Action")
                        .WithMany("FireTruckActions")
                        .HasForeignKey("IdAction")
                        .IsRequired()
                        .HasConstraintName("FireTruckAction_Action_fk");

                    b.HasOne("probne2.Entities.FireTruck", "FireTruck")
                        .WithMany("FireTruckActions")
                        .HasForeignKey("IdFiretruck")
                        .IsRequired()
                        .HasConstraintName("FireTruckAction_FireTruck_fk");

                    b.Navigation("Action");

                    b.Navigation("FireTruck");
                });

            modelBuilder.Entity("probne2.Entities.Action", b =>
                {
                    b.Navigation("FireTruckActions");
                });

            modelBuilder.Entity("probne2.Entities.FireTruck", b =>
                {
                    b.Navigation("FireTruckActions");
                });
#pragma warning restore 612, 618
        }
    }
}
