using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToYoe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "YearOfEnrollment",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 2020);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearOfEnrollment",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "NA");
        }
    }
}
