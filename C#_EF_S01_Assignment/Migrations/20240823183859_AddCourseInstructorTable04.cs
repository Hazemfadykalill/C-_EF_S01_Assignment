using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__EF_S01_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseInstructorTable04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course_Instructor",
                columns: table => new
                {
                    Inst_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Instructor", x => new { x.Course_Id, x.Inst_Id });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Instructor");
        }
    }
}
