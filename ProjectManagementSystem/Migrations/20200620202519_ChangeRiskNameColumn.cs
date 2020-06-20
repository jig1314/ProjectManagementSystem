using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagementSystem.Migrations
{
    public partial class ChangeRiskNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Risk");

            migrationBuilder.AddColumn<string>(
                name: "RiskName",
                table: "Risk",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RiskName",
                table: "Risk");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Risk",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
