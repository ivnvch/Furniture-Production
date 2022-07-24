using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace furniture_Production.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderinEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employee",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employee");
        }
    }
}
