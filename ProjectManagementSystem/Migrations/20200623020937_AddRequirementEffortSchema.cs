using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagementSystem.Migrations
{
    public partial class AddRequirementEffortSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequirementEffort",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRequirement = table.Column<int>(nullable: false),
                    IdTeamMember = table.Column<int>(nullable: false),
                    IdRequirementEffortType = table.Column<int>(nullable: false),
                    IdTimeFrame = table.Column<int>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: true),
                    TimeExpended = table.Column<decimal>(type: "decimal(16,1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementEffort", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequirementEffortTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementEffortTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeFrames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFrames", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequirementEffort");

            migrationBuilder.DropTable(
                name: "RequirementEffortTypes");

            migrationBuilder.DropTable(
                name: "TimeFrames");
        }
    }
}
