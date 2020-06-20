using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagementSystem.Migrations
{
    public partial class Project_TeamMemberMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "TeamMember",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_ProjectId",
                table: "TeamMember",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_Project_ProjectId",
                table: "TeamMember",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_Project_ProjectId",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_ProjectId",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "TeamMember");
        }
    }
}
