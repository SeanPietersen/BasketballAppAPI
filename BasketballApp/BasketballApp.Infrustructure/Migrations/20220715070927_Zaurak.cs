using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketballApp.Infrustructure.Migrations
{
    public partial class Zaurak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    CoachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: false),
                    IsQualified = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.CoachId);
                    table.ForeignKey(
                        name: "FK_Coaches_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlayerHeight = table.Column<double>(type: "float", nullable: false),
                    PlayerWeight = table.Column<double>(type: "float", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "CoachId", "FirstName", "IsQualified", "LastName", "Rank", "TeamId", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Steve", true, "Kerr", 1, 3, 10 },
                    { 2, "Mike", true, "Brown", 2, 3, 5 },
                    { 3, "Frank", false, "Vogel", 1, 1, 2 },
                    { 4, "Mike", true, "Penberthy", 2, 3, 15 },
                    { 5, "Tyronn", true, "Lue", 1, 2, 15 },
                    { 6, "Jason", false, "Powell", 3, 2, 1 },
                    { 7, "Mike", true, "Penberthy", 2, 3, 15 },
                    { 8, "Kevin", false, "Young", 2, 4, 1 },
                    { 9, "Erik", true, "Spoelstra", 1, 6, 5 },
                    { 10, "Nate", false, "McMillan", 1, 8, 2 },
                    { 11, "Todd", false, "Campbell", 3, 9, 1 },
                    { 12, "Ime", false, "Udoka", 1, 10, 4 },
                    { 13, "Ben", true, "Sullivan", 2, 10, 6 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "DateOfBirth", "FirstName", "LastName", "PlayerHeight", "PlayerWeight", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephan", "Curry", 1.8899999999999999, 83.900000000000006, 3 },
                    { 2, new DateTime(1984, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lebron", "James", 2.1000000000000001, 113.40000000000001, 1 },
                    { 3, new DateTime(1991, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kawhi", "Leonard", 2.04, 102.09999999999999, 2 },
                    { 4, new DateTime(1996, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devin", "Booker", 1.98, 93.400000000000006, 4 },
                    { 5, new DateTime(1995, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nikola", "Jokic", 2.2000000000000002, 128.80000000000001, 5 },
                    { 6, new DateTime(1989, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimmy", "Butler", 2.04, 104.3, 6 },
                    { 7, new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gary", "Harris", 1.95, 95.299999999999997, 7 },
                    { 8, new DateTime(1998, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trey", "Young", 1.8600000000000001, 74.400000000000006, 8 },
                    { 9, new DateTime(1997, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lonzo", "Ball", 2.0099999999999998, 86.200000000000003, 9 },
                    { 10, new DateTime(1998, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jayson", "Tatum", 2.0699999999999998, 95.299999999999997, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
