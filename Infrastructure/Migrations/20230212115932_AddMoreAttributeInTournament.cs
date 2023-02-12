using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreAttributeInTournament : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("7cc4bb38-838f-4d3d-9248-a6c9c3f18086"));

            migrationBuilder.AddColumn<bool>(
                name: "isFinished",
                table: "Tournaments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSignUpCompleted",
                table: "Tournaments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isStarted",
                table: "Tournaments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[] { new Guid("2b67b980-9925-4d32-a575-a52fd8f81936"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 12, 59, 31, 950, DateTimeKind.Local).AddTicks(1876), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 12, 59, 31, 950, DateTimeKind.Local).AddTicks(1934), "TS", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("2b67b980-9925-4d32-a575-a52fd8f81936"));

            migrationBuilder.DropColumn(
                name: "isFinished",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "isSignUpCompleted",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "isStarted",
                table: "Tournaments");

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[] { new Guid("7cc4bb38-838f-4d3d-9248-a6c9c3f18086"), "Casablanca", "Morocco", new DateTime(2023, 2, 11, 18, 54, 53, 726, DateTimeKind.Local).AddTicks(6391), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 18, 54, 53, 726, DateTimeKind.Local).AddTicks(6459), "TS", 0 });
        }
    }
}
