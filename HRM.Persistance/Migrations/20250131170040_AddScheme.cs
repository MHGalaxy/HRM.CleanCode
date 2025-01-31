using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HRM");

            migrationBuilder.RenameTable(
                name: "LeaveTypes",
                newName: "LeaveTypes",
                newSchema: "HRM");

            migrationBuilder.RenameTable(
                name: "LeaveRequests",
                newName: "LeaveRequests",
                newSchema: "HRM");

            migrationBuilder.RenameTable(
                name: "LeaveAllocations",
                newName: "LeaveAllocations",
                newSchema: "HRM");

            migrationBuilder.UpdateData(
                schema: "HRM",
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 31, 20, 30, 40, 229, DateTimeKind.Local).AddTicks(5924), new DateTime(2025, 1, 31, 20, 30, 40, 229, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                schema: "HRM",
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 31, 20, 30, 40, 229, DateTimeKind.Local).AddTicks(5935), new DateTime(2025, 1, 31, 20, 30, 40, 229, DateTimeKind.Local).AddTicks(5936) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "LeaveTypes",
                schema: "HRM",
                newName: "LeaveTypes");

            migrationBuilder.RenameTable(
                name: "LeaveRequests",
                schema: "HRM",
                newName: "LeaveRequests");

            migrationBuilder.RenameTable(
                name: "LeaveAllocations",
                schema: "HRM",
                newName: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 31, 20, 26, 32, 644, DateTimeKind.Local).AddTicks(9167), new DateTime(2025, 1, 31, 20, 26, 32, 644, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 31, 20, 26, 32, 644, DateTimeKind.Local).AddTicks(9175), new DateTime(2025, 1, 31, 20, 26, 32, 644, DateTimeKind.Local).AddTicks(9175) });
        }
    }
}
