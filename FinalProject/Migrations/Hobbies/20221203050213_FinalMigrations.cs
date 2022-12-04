using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations.Hobbies
{
    public partial class FinalMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobby_Name1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobby_Name2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hours_Spent1 = table.Column<int>(type: "int", nullable: false),
                    Hours_Spent2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.User_id);
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "User_id", "First_Name", "Hobby_Name1", "Hobby_Name2", "Hours_Spent1", "Hours_Spent2", "Last_Name" },
                values: new object[] { 1, "Joshua", "FL Studio", "Fixing Computers", 1435, 500, "Chapman" });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "User_id", "First_Name", "Hobby_Name1", "Hobby_Name2", "Hours_Spent1", "Hours_Spent2", "Last_Name" },
                values: new object[] { 2, "Tigran", "Playing Games", "Working out", 3000, 85, "Klekchyan" });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "User_id", "First_Name", "Hobby_Name1", "Hobby_Name2", "Hours_Spent1", "Hours_Spent2", "Last_Name" },
                values: new object[] { 3, "Andrew", "Playing Cards", "Playing Games", 1500, 1370, "Iverson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobby");
        }
    }
}
