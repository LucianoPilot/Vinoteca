using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vinoteca.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Wines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 12, 6, 19, 29, 209, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Wines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 12, 6, 19, 29, 209, DateTimeKind.Utc).AddTicks(5436));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Wines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 12, 6, 4, 48, 211, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Wines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 12, 6, 4, 48, 211, DateTimeKind.Utc).AddTicks(9003));
        }
    }
}
