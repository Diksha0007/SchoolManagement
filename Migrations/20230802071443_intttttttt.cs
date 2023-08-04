using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement1.Migrations
{
    public partial class intttttttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourceName",
                table: "Courses",
                newName: "CourseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Courses",
                newName: "CourceName");
        }
    }
}
