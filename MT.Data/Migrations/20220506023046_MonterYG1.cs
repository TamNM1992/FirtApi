using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class MonterYG1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtkBase = table.Column<int>(type: "int", nullable: false),
                    DefBase = table.Column<int>(type: "int", nullable: false),
                    SpeedBase = table.Column<int>(type: "int", nullable: false),
                    StrengBase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtkBase = table.Column<int>(type: "int", nullable: false),
                    DefBase = table.Column<int>(type: "int", nullable: false),
                    SpeedBase = table.Column<int>(type: "int", nullable: false),
                    StrengBase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Atk = table.Column<int>(type: "int", nullable: false),
                    Def = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    AttributeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManaCurrent = table.Column<int>(type: "int", nullable: false),
                    HealCurrent = table.Column<int>(type: "int", nullable: false),
                    ShieldCurrent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Monters_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monters_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeSkillId = table.Column<int>(type: "int", nullable: true),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ManaConsume = table.Column<int>(type: "int", nullable: false),
                    EffectiveTime = table.Column<int>(type: "int", nullable: false),
                    CoolDownTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_TypeSkills_TypeSkillId",
                        column: x => x.TypeSkillId,
                        principalTable: "TypeSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monters_AttributeId",
                table: "Monters",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_TypeId",
                table: "Monters",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TypeSkillId",
                table: "Skills",
                column: "TypeSkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monters");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "TypeSkills");
        }
    }
}
