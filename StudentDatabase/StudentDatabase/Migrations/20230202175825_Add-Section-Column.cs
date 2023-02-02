using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "NA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section",
                table: "Student");
        }
    }
}
