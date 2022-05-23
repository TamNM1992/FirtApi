using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class MonterYG8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_TypeSkills_TypeSkillID",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "TypeSkills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_TypeSkillID",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "TypeSkillID",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "TypeSkill",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeSkill",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "TypeSkillID",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypeSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSkills", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TypeSkillID",
                table: "Skills",
                column: "TypeSkillID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_TypeSkills_TypeSkillID",
                table: "Skills",
                column: "TypeSkillID",
                principalTable: "TypeSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
