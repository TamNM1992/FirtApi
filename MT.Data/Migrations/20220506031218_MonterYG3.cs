using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class MonterYG3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Attributes_AttributeId",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Types_TypeId",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_TypeSkills_TypeSkillId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "TypeSkillId",
                table: "Skills",
                newName: "TypeSkillID");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_TypeSkillId",
                table: "Skills",
                newName: "IX_Skills_TypeSkillID");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Monters",
                newName: "TypeID");

            migrationBuilder.RenameColumn(
                name: "AttributeId",
                table: "Monters",
                newName: "AttributeID");

            migrationBuilder.RenameColumn(
                name: "ShieldCurrent",
                table: "Monters",
                newName: "W_ID");

            migrationBuilder.RenameColumn(
                name: "ManaCurrent",
                table: "Monters",
                newName: "U_ID");

            migrationBuilder.RenameColumn(
                name: "HealCurrent",
                table: "Monters",
                newName: "Q_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Monters_TypeId",
                table: "Monters",
                newName: "IX_Monters_TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Monters_AttributeId",
                table: "Monters",
                newName: "IX_Monters_AttributeID");

            migrationBuilder.AlterColumn<int>(
                name: "TypeSkillID",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttributeID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "E_ID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EskillId",
                table: "Monters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QskillId",
                table: "Monters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UltimateId",
                table: "Monters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WskillId",
                table: "Monters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monters_EskillId",
                table: "Monters",
                column: "EskillId");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_QskillId",
                table: "Monters",
                column: "QskillId");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_UltimateId",
                table: "Monters",
                column: "UltimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_WskillId",
                table: "Monters",
                column: "WskillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Attributes_AttributeID",
                table: "Monters",
                column: "AttributeID",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_EskillId",
                table: "Monters",
                column: "EskillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_QskillId",
                table: "Monters",
                column: "QskillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_UltimateId",
                table: "Monters",
                column: "UltimateId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_WskillId",
                table: "Monters",
                column: "WskillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Types_TypeID",
                table: "Monters",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_TypeSkills_TypeSkillID",
                table: "Skills",
                column: "TypeSkillID",
                principalTable: "TypeSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Attributes_AttributeID",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_EskillId",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_QskillId",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_UltimateId",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_WskillId",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Types_TypeID",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_TypeSkills_TypeSkillID",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Monters_EskillId",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_QskillId",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_UltimateId",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_WskillId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "E_ID",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "EskillId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "QskillId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "UltimateId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "WskillId",
                table: "Monters");

            migrationBuilder.RenameColumn(
                name: "TypeSkillID",
                table: "Skills",
                newName: "TypeSkillId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_TypeSkillID",
                table: "Skills",
                newName: "IX_Skills_TypeSkillId");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "Monters",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "AttributeID",
                table: "Monters",
                newName: "AttributeId");

            migrationBuilder.RenameColumn(
                name: "W_ID",
                table: "Monters",
                newName: "ShieldCurrent");

            migrationBuilder.RenameColumn(
                name: "U_ID",
                table: "Monters",
                newName: "ManaCurrent");

            migrationBuilder.RenameColumn(
                name: "Q_ID",
                table: "Monters",
                newName: "HealCurrent");

            migrationBuilder.RenameIndex(
                name: "IX_Monters_TypeID",
                table: "Monters",
                newName: "IX_Monters_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Monters_AttributeID",
                table: "Monters",
                newName: "IX_Monters_AttributeId");

            migrationBuilder.AlterColumn<int>(
                name: "TypeSkillId",
                table: "Skills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Monters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeId",
                table: "Monters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Attributes_AttributeId",
                table: "Monters",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Types_TypeId",
                table: "Monters",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_TypeSkills_TypeSkillId",
                table: "Skills",
                column: "TypeSkillId",
                principalTable: "TypeSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
