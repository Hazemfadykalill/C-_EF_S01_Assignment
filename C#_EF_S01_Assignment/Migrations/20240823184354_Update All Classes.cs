using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__EF_S01_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopicName",
                table: "Topics",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TopicName",
                table: "Departments",
                newName: "Name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "HiringDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Topics",
                newName: "TopicName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "TopicName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "HiringDate",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
