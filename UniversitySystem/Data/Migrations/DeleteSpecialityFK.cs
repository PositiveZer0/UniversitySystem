using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversitySystem.Data.Migrations
{
    public partial class DeleteSpecialityFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Specialities_SpecialityId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_SpecialityId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Subjects");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SpecialityId",
                table: "Subjects",
                column: "SpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Specialities_SpecialityId",
                table: "Subjects",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
