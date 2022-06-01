using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace probne2.Migrations
{
    public partial class AddedCfTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Action",
                columns: new[] { "IdAction", "EndTime", "NeedSpecialEquipment", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4360) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4520) }
                });

            migrationBuilder.InsertData(
                table: "FireTruck",
                columns: new[] { "IdFiretruck", "OperationNumber", "SpecialEquipment" },
                values: new object[,]
                {
                    { 1, "1", true },
                    { 2, "2", false },
                    { 3, "3", true }
                });

            migrationBuilder.InsertData(
                table: "FireTruck_Action",
                columns: new[] { "IdAction", "IdFiretruck", "AssignmentDate" },
                values: new object[] { 1, 1, new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.InsertData(
                table: "FireTruck_Action",
                columns: new[] { "IdAction", "IdFiretruck", "AssignmentDate" },
                values: new object[] { 2, 2, new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4540) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FireTruck",
                keyColumn: "IdFiretruck",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FireTruck_Action",
                keyColumns: new[] { "IdAction", "IdFiretruck" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FireTruck_Action",
                keyColumns: new[] { "IdAction", "IdFiretruck" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Action",
                keyColumn: "IdAction",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Action",
                keyColumn: "IdAction",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FireTruck",
                keyColumn: "IdFiretruck",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FireTruck",
                keyColumn: "IdFiretruck",
                keyValue: 2);
        }
    }
}
