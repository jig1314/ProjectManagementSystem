using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagementSystem.Migrations
{
    public partial class SeedRequirementEffortTypeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "insert into RequirementEffortTypes (DisplayName) values ('Requirements Analysis'), ('Designing'), ('Coding'), ('Testing'), ('Project Management')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
