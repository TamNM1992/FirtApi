using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.Data.Migrations
{
    public partial class monteryg17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorityDtoUser");

            migrationBuilder.CreateTable(
                name: "AuthorityUser",
                columns: table => new
                {
                    AuthoritiesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorityUser", x => new { x.AuthoritiesID, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AuthorityUser_Authorities_AuthoritiesID",
                        column: x => x.AuthoritiesID,
                        principalTable: "Authorities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorityUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityUser_UsersId",
                table: "AuthorityUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorityUser");

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
    }
}
