using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class MonterYG6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TypeSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Types",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TypeSkills");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Types");
        }
    }
}
