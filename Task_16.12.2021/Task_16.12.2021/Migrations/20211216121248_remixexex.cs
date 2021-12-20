using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_16._12._2021.Migrations
{
    public partial class remixexex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_CustomUserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CustomUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "StaticUserId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StaticUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_StaticUserId",
                table: "Blogs",
                column: "StaticUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_StaticUser_StaticUserId",
                table: "Blogs",
                column: "StaticUserId",
                principalTable: "StaticUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_StaticUser_StaticUserId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "StaticUser");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_StaticUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "StaticUserId",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CustomUserId",
                table: "Blogs",
                column: "CustomUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_CustomUserId",
                table: "Blogs",
                column: "CustomUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
