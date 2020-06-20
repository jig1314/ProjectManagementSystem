using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagementSystem.Migrations
{
    public partial class FixMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ProjectTeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProject = table.Column<int>(nullable: false),
                    IdTeamMember = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeamMembers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTeamMembers");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "TeamMember",
                type: "int",
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
    }
}
