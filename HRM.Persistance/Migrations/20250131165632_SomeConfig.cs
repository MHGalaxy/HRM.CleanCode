using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SomeConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 31, 20, 24, 44, 49, DateTimeKind.Local).AddTicks(8610), new DateTime(2025, 1, 31, 20, 24, 44, 49, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 31, 20, 24, 44, 49, DateTimeKind.Local).AddTicks(8618), new DateTime(2025, 1, 31, 20, 24, 44, 49, DateTimeKind.Local).AddTicks(8619) });
        }
    }
}
