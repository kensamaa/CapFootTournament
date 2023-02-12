using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateDataCapgemini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("905a4e31-16ca-4b5c-874b-f07f6131b00d"));

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[,]
                {
                    { new Guid("2307aad8-f07b-497a-a02b-db23bc0c6ee0"), "Rabat", "Morocco", new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3532), "TS", 8 },
                    { new Guid("50630809-0da5-43c7-b8e1-08135a031773"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3523), "TS", 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("2307aad8-f07b-497a-a02b-db23bc0c6ee0"));

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("50630809-0da5-43c7-b8e1-08135a031773"));

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[] { new Guid("905a4e31-16ca-4b5c-874b-f07f6131b00d"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 13, 37, 12, 75, DateTimeKind.Local).AddTicks(9145), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 13, 37, 12, 75, DateTimeKind.Local).AddTicks(9400), "TS", 0 });
        }
    }
}
