using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class monteryg16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorities",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AuthorityDtoUser",
                columns: table => new
                {
                    AuthoritiesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorityDtoUser", x => new { x.AuthoritiesID, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AuthorityDtoUser_Authorities_AuthoritiesID",
                        column: x => x.AuthoritiesID,
                        principalTable: "Authorities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorityDtoUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityDtoUser_UsersId",
                table: "AuthorityDtoUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorityDtoUser");

            migrationBuilder.DropTable(
                name: "Authorities");
        }
    }
}
