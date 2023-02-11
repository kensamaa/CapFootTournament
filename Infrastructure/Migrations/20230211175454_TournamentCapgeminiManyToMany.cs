using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TournamentCapgeminiManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("3a740281-a65c-44b9-a78c-f5e2be272cff"));

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTeams",
                table: "Capgeminis",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name", "NumberOfTeams" },
                values: new object[] { new Guid("7cc4bb38-838f-4d3d-9248-a6c9c3f18086"), "Casablanca", "Morocco", new DateTime(2023, 2, 11, 18, 54, 53, 726, DateTimeKind.Local).AddTicks(6391), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 18, 54, 53, 726, DateTimeKind.Local).AddTicks(6459), "TS", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_CapgeminiTournament_TournamentsId",
                table: "CapgeminiTournament",
                column: "TournamentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapgeminiTournament");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DeleteData(
                table: "Capgeminis",
                keyColumn: "Id",
                keyValue: new Guid("7cc4bb38-838f-4d3d-9248-a6c9c3f18086"));

            migrationBuilder.DropColumn(
                name: "NumberOfTeams",
                table: "Capgeminis");

            migrationBuilder.InsertData(
                table: "Capgeminis",
                columns: new[] { "Id", "City", "Country", "DateCreated", "DateCreation", "DateModified", "Name" },
                values: new object[] { new Guid("3a740281-a65c-44b9-a78c-f5e2be272cff"), "Casablanca", "Morocco", new DateTime(2023, 2, 3, 2, 36, 23, 808, DateTimeKind.Local).AddTicks(6180), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 2, 36, 23, 808, DateTimeKind.Local).AddTicks(6266), "TS" });
        }
    }
}
