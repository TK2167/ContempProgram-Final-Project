using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class FinalMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavGame",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Game_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release_Date = table.Column<int>(type: "int", nullable: false),
                    Release_Platform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hours_Played = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavGame", x => x.User_id);
                });

            migrationBuilder.InsertData(
                table: "FavGame",
                columns: new[] { "User_id", "First_Name", "Game_Name", "Hours_Played", "Last_Name", "Release_Date", "Release_Platform" },
                values: new object[] { 1, "Joshua", "Modern Warfare 2", 3, "Chapman", 2022, "Console and PC" });

            migrationBuilder.InsertData(
                table: "FavGame",
                columns: new[] { "User_id", "First_Name", "Game_Name", "Hours_Played", "Last_Name", "Release_Date", "Release_Platform" },
                values: new object[] { 2, "Tigran", "Dota 2", 2501, "Klekchyan", 2013, "PC" });

            migrationBuilder.InsertData(
                table: "FavGame",
                columns: new[] { "User_id", "First_Name", "Game_Name", "Hours_Played", "Last_Name", "Release_Date", "Release_Platform" },
                values: new object[] { 3, "Andrew", "Red Dead Redemtion 2", 77, "Iverson", 2018, "Console and PC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavGame");
        }
    }
}
