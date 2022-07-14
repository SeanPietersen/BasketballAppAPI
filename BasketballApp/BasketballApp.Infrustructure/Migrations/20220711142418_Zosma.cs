using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketballApp.Infrustructure.Migrations
{
    public partial class Zosma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "seanpietersen7@gmail.com", "Sean", "Pietersen", "Sean2563" },
                    { 2, "jase.pietersen7@gmail.com", "Jason", "Pietersen", "Jason2563" },
                    { 3, "pfpietersen@gmail.com", "Percival", "Pietersen", "Percy50" },
                    { 4, "cmpietersen7@gmail.com", "Claudia", "Pietersen", "Claudia2563" },
                    { 5, "rumerkerm@gmail.com", "Rumer", "Manis", "Rumer1234" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
