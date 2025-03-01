using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaProject.Migrations
{
    /// <inheritdoc />
    public partial class blogTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectImage_Projects_ProjectId",
                table: "ProjectImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectImage",
                table: "ProjectImage");

            migrationBuilder.RenameTable(
                name: "ProjectImage",
                newName: "ProjectImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectImage_ProjectId",
                table: "ProjectImages",
                newName: "IX_ProjectImages_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectImages",
                table: "ProjectImages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImages_Projects_ProjectId",
                table: "ProjectImages",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectImages_Projects_ProjectId",
                table: "ProjectImages");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectImages",
                table: "ProjectImages");

            migrationBuilder.RenameTable(
                name: "ProjectImages",
                newName: "ProjectImage");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectImages_ProjectId",
                table: "ProjectImage",
                newName: "IX_ProjectImage_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectImage",
                table: "ProjectImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImage_Projects_ProjectId",
                table: "ProjectImage",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
