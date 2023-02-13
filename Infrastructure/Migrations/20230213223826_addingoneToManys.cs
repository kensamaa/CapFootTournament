using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingoneToManys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Classement = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapgeminiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Groups_GroupeId",
                        column: x => x.GroupeId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Goalminute = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goal_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[,]
                {
                    { new Guid("cc402388-bd5e-469e-aca6-14b937f1cca2"), "Rabat", "Morocco", new DateTime(2023, 2, 13, 23, 38, 25, 985, DateTimeKind.Local).AddTicks(6091), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 23, 38, 25, 985, DateTimeKind.Local).AddTicks(6093), "TS", 8 },
                    { new Guid("f6b28cac-740d-47a5-a245-faafe5ba0961"), "Casablanca", "Morocco", new DateTime(2023, 2, 13, 23, 38, 25, 985, DateTimeKind.Local).AddTicks(6028), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 23, 38, 25, 985, DateTimeKind.Local).AddTicks(6085), "TS", 16 }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "CountryOrganisation", "DateCreated", "DateModified", "Name", "isFinished", "isSignUpCompleted", "isStarted" },
                values: new object[] { new Guid("3230b4a1-6d9a-48ce-99ed-1fda2d4dd2a5"), "Maroc", new DateTime(2023, 2, 13, 23, 38, 25, 986, DateTimeKind.Local).AddTicks(1084), new DateTime(2023, 2, 13, 23, 38, 25, 986, DateTimeKind.Local).AddTicks(1106), "Tournoi Ramadan", false, false, false });

            migrationBuilder.CreateIndex(
                name: "IX_Card_PlayerId",
                table: "Card",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Goal_PlayerId",
                table: "Goal",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_GroupeId",
                table: "Team",
                column: "GroupeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("cc402388-bd5e-469e-aca6-14b937f1cca2"));

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("f6b28cac-740d-47a5-a245-faafe5ba0961"));

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: new Guid("3230b4a1-6d9a-48ce-99ed-1fda2d4dd2a5"));

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
        }
    }
}
