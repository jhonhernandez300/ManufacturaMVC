using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class CustomerRegionNamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerRegion",
                table: "CustomerRegions");

            migrationBuilder.AddColumn<string>(
                name: "CustomerRegionName",
                table: "CustomerRegions",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerRegionName",
                table: "CustomerRegions");

            migrationBuilder.AddColumn<string>(
                name: "CustomerRegion",
                table: "CustomerRegions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
