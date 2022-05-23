using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class MonterYG2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "E_ID",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "Q_ID",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "U_ID",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "W_ID",
                table: "Monters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "E_ID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Q_ID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "U_ID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "W_ID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
