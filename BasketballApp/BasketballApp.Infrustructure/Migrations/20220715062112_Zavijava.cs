using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketballApp.Infrustructure.Migrations
{
    public partial class Zavijava : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Los Angeles Lakers", "Claifornia" },
                    { 2, "Los Angeles Clippers", "Claifornia" },
                    { 3, "Golden State Warriors", "Claifornia" },
                    { 4, "Phoenix Suns", "Arizona" },
                    { 5, "Denvor Nuggets", "Colorado" },
                    { 6, "Miami Heat", "Florida" },
                    { 7, "Orlando Magic", "Florida" },
                    { 8, "Atlanta Hawks", "Georgia" },
                    { 9, "Chicago Bulls", "Illinois" },
                    { 10, "Boston Celtics", "Massachusetts" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
