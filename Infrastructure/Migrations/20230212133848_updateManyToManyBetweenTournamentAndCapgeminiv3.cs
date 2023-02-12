using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateManyToManyBetweenTournamentAndCapgeminiv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("4bb044cf-bd62-4ec0-9f95-faaaacc03554"));

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("f905d4e5-e7ca-4b1b-9e18-1538ff6ea50f"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("3103ad2f-e6d0-424e-b031-805461bf536e"));

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[,]
                {
                    { new Guid("002908a6-84b5-4b44-89ef-af09ed65f1a4"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6684), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6745), "TS", 16 },
                    { new Guid("274bc7f6-c1a7-42ec-bc03-3be2c70421a9"), "Rabat", "Morocco", new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6768), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 14, 38, 47, 791, DateTimeKind.Local).AddTicks(6771), "TS", 8 }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "CountryOrganisation", "DateCreated", "DateModified", "Name", "isFinished", "isSignUpCompleted", "isStarted" },
                values: new object[] { new Guid("eba9ffc2-46bc-45e4-916f-29ab4d8b5cd5"), "Maroc", new DateTime(2023, 2, 12, 14, 38, 47, 792, DateTimeKind.Local).AddTicks(2015), new DateTime(2023, 2, 12, 14, 38, 47, 792, DateTimeKind.Local).AddTicks(2046), "Tournoi Ramadan", false, false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("002908a6-84b5-4b44-89ef-af09ed65f1a4"));

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("274bc7f6-c1a7-42ec-bc03-3be2c70421a9"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("eba9ffc2-46bc-45e4-916f-29ab4d8b5cd5"));

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[,]
                {
                    { new Guid("4bb044cf-bd62-4ec0-9f95-faaaacc03554"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 14, 12, 28, 848, DateTimeKind.Local).AddTicks(1215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 14, 12, 28, 848, DateTimeKind.Local).AddTicks(1275), "TS", 16 },
                    { new Guid("f905d4e5-e7ca-4b1b-9e18-1538ff6ea50f"), "Rabat", "Morocco", new DateTime(2023, 2, 12, 14, 12, 28, 848, DateTimeKind.Local).AddTicks(1282), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 14, 12, 28, 848, DateTimeKind.Local).AddTicks(1284), "TS", 8 }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "CountryOrganisation", "DateCreated", "DateModified", "Name", "isFinished", "isSignUpCompleted", "isStarted" },
                values: new object[] { new Guid("3103ad2f-e6d0-424e-b031-805461bf536e"), "Maroc", new DateTime(2023, 2, 12, 14, 12, 28, 848, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 2, 12, 14, 12, 28, 848, DateTimeKind.Local).AddTicks(5463), "Tournoi Ramadan", false, false, false });
        }
    }
}
