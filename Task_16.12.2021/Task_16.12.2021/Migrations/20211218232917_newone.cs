using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_16._12._2021.Migrations
{
    public partial class newone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagToWorks_OurWorks_WorkTagId",
                table: "TagToWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToWorks_WorkTags_OurWorkId",
                table: "TagToWorks");

            migrationBuilder.AddForeignKey(
                name: "FK_TagToWorks_OurWorks_OurWorkId",
                table: "TagToWorks",
                column: "OurWorkId",
                principalTable: "OurWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagToWorks_WorkTags_WorkTagId",
                table: "TagToWorks",
                column: "WorkTagId",
                principalTable: "WorkTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagToWorks_OurWorks_OurWorkId",
                table: "TagToWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_TagToWorks_WorkTags_WorkTagId",
                table: "TagToWorks");

            migrationBuilder.AddForeignKey(
                name: "FK_TagToWorks_OurWorks_WorkTagId",
                table: "TagToWorks",
                column: "WorkTagId",
                principalTable: "OurWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagToWorks_WorkTags_OurWorkId",
                table: "TagToWorks",
                column: "OurWorkId",
                principalTable: "WorkTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
