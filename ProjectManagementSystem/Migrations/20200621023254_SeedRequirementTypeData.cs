using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagementSystem.Migrations
{
    public partial class SeedRequirementTypeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "insert into RequirementTypes (DisplayName) values ('Functional'), ('Non-Functional')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
