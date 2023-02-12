using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateManyToManyBetweenTournamentAndCapgeminiv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapgeminiTournament");

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("2307aad8-f07b-497a-a02b-db23bc0c6ee0"));

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("50630809-0da5-43c7-b8e1-08135a031773"));

            migrationBuilder.CreateTable(
                name: "CapgeminiTournaments",
                columns: table => new
                {
                    capgeminiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapgeminiTournaments", x => new { x.tournamentId, x.capgeminiId });
                    table.ForeignKey(
                        name: "FK_CapgeminiTournaments_Capgeminis_capgeminiId",
                        column: x => x.capgeminiId,
                        principalTable: "Capgeminis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CapgeminiTournaments_Tournaments_tournamentId",
                        column: x => x.tournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CapgeminiTournaments_capgeminiId",
                table: "CapgeminiTournaments",
                column: "capgeminiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapgeminiTournaments");

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

            migrationBuilder.CreateTable(
                name: "CapgeminiTournament",
                columns: table => new
                {
                    CapgeminisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TournamentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapgeminiTournament", x => new { x.CapgeminisId, x.TournamentsId });
                    table.ForeignKey(
                        name: "FK_CapgeminiTournament_Capgeminis_CapgeminisId",
                        column: x => x.CapgeminisId,
                        principalTable: "Capgeminis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CapgeminiTournament_Tournaments_TournamentsId",
                        column: x => x.TournamentsId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[,]
                {
                    { new Guid("2307aad8-f07b-497a-a02b-db23bc0c6ee0"), "Rabat", "Morocco", new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3532), "TS", 8 },
                    { new Guid("50630809-0da5-43c7-b8e1-08135a031773"), "Casablanca", "Morocco", new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 13, 44, 6, 5, DateTimeKind.Local).AddTicks(3523), "TS", 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CapgeminiTournament_TournamentsId",
                table: "CapgeminiTournament",
                column: "TournamentsId");
        }
    }
}
