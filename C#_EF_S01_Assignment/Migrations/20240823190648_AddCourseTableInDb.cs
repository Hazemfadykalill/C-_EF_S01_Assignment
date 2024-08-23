using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__EF_S01_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseTableInDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_Course",
                table: "Student_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Instructor",
                table: "Course_Instructor");

            migrationBuilder.RenameTable(
                name: "Student_Course",
                newName: "Student_Courses");

            migrationBuilder.RenameTable(
                name: "Course_Instructor",
                newName: "Course_Instructors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_Courses",
                table: "Student_Courses",
                columns: new[] { "Course_Id", "Student_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Instructors",
                table: "Course_Instructors",
                columns: new[] { "Course_Id", "Inst_Id" });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Top_Id = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<DateTime>(type: "datetime", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_Courses",
                table: "Student_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Instructors",
                table: "Course_Instructors");

            migrationBuilder.RenameTable(
                name: "Student_Courses",
                newName: "Student_Course");

            migrationBuilder.RenameTable(
                name: "Course_Instructors",
                newName: "Course_Instructor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_Course",
                table: "Student_Course",
                columns: new[] { "Course_Id", "Student_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Instructor",
                table: "Course_Instructor",
                columns: new[] { "Course_Id", "Inst_Id" });
        }
    }
}
