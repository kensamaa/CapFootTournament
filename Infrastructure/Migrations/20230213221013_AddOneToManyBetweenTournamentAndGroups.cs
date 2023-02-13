using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToManyBetweenTournamentAndGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("84194159-0a0c-4f7a-b7e5-27023df006ac"), "Casablanca", "Morocco", new DateTime(2023, 2, 13, 23, 10, 13, 245, DateTimeKind.Local).AddTicks(5896), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 23, 10, 13, 245, DateTimeKind.Local).AddTicks(5972), "TS", 16 },
                    { new Guid("aa7c4614-06e8-450f-bce5-f814c0c874ec"), "Rabat", "Morocco", new DateTime(2023, 2, 13, 23, 10, 13, 245, DateTimeKind.Local).AddTicks(6142), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 23, 10, 13, 245, DateTimeKind.Local).AddTicks(6146), "TS", 8 }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "CountryOrganisation", "DateCreated", "DateModified", "Name", "isFinished", "isSignUpCompleted", "isStarted" },
                values: new object[] { new Guid("b4f9c70e-26d7-4f47-b47e-aaea4e2704e3"), "Maroc", new DateTime(2023, 2, 13, 23, 10, 13, 246, DateTimeKind.Local).AddTicks(4742), new DateTime(2023, 2, 13, 23, 10, 13, 246, DateTimeKind.Local).AddTicks(4784), "Tournoi Ramadan", false, false, false });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TournamentId",
                table: "Groups",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Tournaments_TournamentId",
                table: "Groups",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Tournaments_TournamentId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_TournamentId",
                table: "Groups");

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("84194159-0a0c-4f7a-b7e5-27023df006ac"));

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("aa7c4614-06e8-450f-bce5-f814c0c874ec"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("b4f9c70e-26d7-4f47-b47e-aaea4e2704e3"));

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
    }
}
