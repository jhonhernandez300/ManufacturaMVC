using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class duplicado3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegionIdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCities_CustomerRegionIdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "CustomerRegionIdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCities_IdCustomerRegion",
                table: "CustomerCities",
                column: "IdCustomerRegion");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCities_CustomerRegions_IdCustomerRegion",
                table: "CustomerCities",
                column: "IdCustomerRegion",
                principalTable: "CustomerRegions",
                principalColumn: "IdCustomerRegion",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCities_CustomerRegions_IdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCities_IdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.AddColumn<int>(
                name: "CustomerRegionIdCustomerRegion",
                table: "CustomerCities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCities_CustomerRegionIdCustomerRegion",
                table: "CustomerCities",
                column: "CustomerRegionIdCustomerRegion");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegionIdCustomerRegion",
                table: "CustomerCities",
                column: "CustomerRegionIdCustomerRegion",
                principalTable: "CustomerRegions",
                principalColumn: "IdCustomerRegion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
