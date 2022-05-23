using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class MonterYG10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monters",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_AttributeID",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_EskillId",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_QskillId",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_TypeID",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_UltimateId",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_WskillId",
                table: "Monters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "AttributeID",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "EskillId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "QskillId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "UltimateId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "WskillId",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Attributes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Types",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skills",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Monters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attribute",
                table: "Monters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EskillSkillName",
                table: "Monters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QskillSkillName",
                table: "Monters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Monters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UltimateSkillName",
                table: "Monters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WskillSkillName",
                table: "Monters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Attributes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "SkillName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monters",
                table: "Monters",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_EskillSkillName",
                table: "Monters",
                column: "EskillSkillName");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_QskillSkillName",
                table: "Monters",
                column: "QskillSkillName");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_UltimateSkillName",
                table: "Monters",
                column: "UltimateSkillName");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_WskillSkillName",
                table: "Monters",
                column: "WskillSkillName");

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_EskillSkillName",
                table: "Monters",
                column: "EskillSkillName",
                principalTable: "Skills",
                principalColumn: "SkillName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_QskillSkillName",
                table: "Monters",
                column: "QskillSkillName",
                principalTable: "Skills",
                principalColumn: "SkillName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_UltimateSkillName",
                table: "Monters",
                column: "UltimateSkillName",
                principalTable: "Skills",
                principalColumn: "SkillName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monters_Skills_WskillSkillName",
                table: "Monters",
                column: "WskillSkillName",
                principalTable: "Skills",
                principalColumn: "SkillName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_EskillSkillName",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_QskillSkillName",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_UltimateSkillName",
                table: "Monters");

            migrationBuilder.DropForeignKey(
                name: "FK_Monters_Skills_WskillSkillName",
                table: "Monters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monters",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_EskillSkillName",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_QskillSkillName",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_UltimateSkillName",
                table: "Monters");

            migrationBuilder.DropIndex(
                name: "IX_Monters_WskillSkillName",
                table: "Monters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "Attribute",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "EskillSkillName",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "QskillSkillName",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "UltimateSkillName",
                table: "Monters");

            migrationBuilder.DropColumn(
                name: "WskillSkillName",
                table: "Monters");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Types",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Types",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Monters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AttributeID",
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
                name: "TypeID",
                table: "Monters",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Attributes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Attributes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monters",
                table: "Monters",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_AttributeID",
                table: "Monters",
                column: "AttributeID");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_EskillId",
                table: "Monters",
                column: "EskillId");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_QskillId",
                table: "Monters",
                column: "QskillId");

            migrationBuilder.CreateIndex(
                name: "IX_Monters_TypeID",
                table: "Monters",
                column: "TypeID");

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
        }
    }
}
