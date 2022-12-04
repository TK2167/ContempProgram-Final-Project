using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations.MembersInfo
{
    public partial class FinalMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberInfo",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthdate = table.Column<int>(type: "int", nullable: false),
                    College_Program = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Program_year = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberInfo", x => x.User_id);
                });

            migrationBuilder.InsertData(
                table: "MemberInfo",
                columns: new[] { "User_id", "Birthdate", "College_Program", "First_Name", "Last_Name", "Program_year" },
                values: new object[] { 1, 0, "Information Technology", "Joshua", "Chapman", "Sophmore" });

            migrationBuilder.InsertData(
                table: "MemberInfo",
                columns: new[] { "User_id", "Birthdate", "College_Program", "First_Name", "Last_Name", "Program_year" },
                values: new object[] { 2, 0, "Information Technology", "Tigran", "Klekchyan", "Senior" });

            migrationBuilder.InsertData(
                table: "MemberInfo",
                columns: new[] { "User_id", "Birthdate", "College_Program", "First_Name", "Last_Name", "Program_year" },
                values: new object[] { 3, 0, "Information Technology", "Andrew", "Iverson", "Sophmore" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberInfo");
        }
    }
}
