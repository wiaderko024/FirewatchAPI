using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace probne2.Migrations
{
    public partial class AddCfTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Action",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "IdAction",
                keyValue: 1,
                column: "StartTime",
                value: new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "IdAction",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { null, new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "FireTruck_Action",
                keyColumns: new[] { "IdAction", "IdFiretruck" },
                keyValues: new object[] { 1, 1 },
                column: "AssignmentDate",
                value: new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "FireTruck_Action",
                keyColumns: new[] { "IdAction", "IdFiretruck" },
                keyValues: new object[] { 2, 2 },
                column: "AssignmentDate",
                value: new DateTime(2022, 6, 1, 22, 16, 42, 55, DateTimeKind.Local).AddTicks(2690));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Action",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "IdAction",
                keyValue: 1,
                column: "StartTime",
                value: new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Action",
                keyColumn: "IdAction",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "FireTruck_Action",
                keyColumns: new[] { "IdAction", "IdFiretruck" },
                keyValues: new object[] { 1, 1 },
                column: "AssignmentDate",
                value: new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "FireTruck_Action",
                keyColumns: new[] { "IdAction", "IdFiretruck" },
                keyValues: new object[] { 2, 2 },
                column: "AssignmentDate",
                value: new DateTime(2022, 6, 1, 14, 31, 53, 667, DateTimeKind.Local).AddTicks(4540));
        }
    }
}
