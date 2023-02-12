using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateManyToManyBetweenTournamentAndCapgemini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("2b67b980-9925-4d32-a575-a52fd8f81936"));

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[] { new Guid("905a4e31-16ca-4b5c-874b-f07f6131b00d"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 13, 37, 12, 75, DateTimeKind.Local).AddTicks(9145), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 13, 37, 12, 75, DateTimeKind.Local).AddTicks(9400), "TS", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("905a4e31-16ca-4b5c-874b-f07f6131b00d"));

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[] { new Guid("2b67b980-9925-4d32-a575-a52fd8f81936"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 12, 59, 31, 950, DateTimeKind.Local).AddTicks(1876), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 12, 59, 31, 950, DateTimeKind.Local).AddTicks(1934), "TS", 0 });
        }
    }
}
