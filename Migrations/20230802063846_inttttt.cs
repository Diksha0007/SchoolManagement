using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement1.Migrations
{
    public partial class inttttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Students",
                newName: "CourseId");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourceName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Students",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
