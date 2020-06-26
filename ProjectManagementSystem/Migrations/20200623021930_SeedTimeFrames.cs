using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagementSystem.Migrations
{
    public partial class SeedTimeFrames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "insert into TimeFrames (DisplayName) values ('Daily'), ('Weekly')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
