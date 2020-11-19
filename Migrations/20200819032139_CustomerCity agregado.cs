using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class CustomerCityagregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryNameIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRegions_CustomerCountryNameIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "CustomerCountryNameIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "CustomerCity",
                table: "CustomerCities");

            migrationBuilder.AddColumn<string>(
                name: "CustomerCityName",
                table: "CustomerCities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCustomerRegion",
                table: "CustomerCities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_IdCustomerCountry",
                table: "CustomerRegions",
                column: "IdCustomerCountry");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_IdCustomerCountry",
                table: "CustomerRegions",
                column: "IdCustomerCountry",
                principalTable: "CustomerCountries",
                principalColumn: "IdCustomerCountry",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_IdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRegions_IdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "CustomerCityName",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "IdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCountryNameIdCustomerCountry",
                table: "CustomerRegions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCity",
                table: "CustomerCities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_CustomerCountryNameIdCustomerCountry",
                table: "CustomerRegions",
                column: "CustomerCountryNameIdCustomerCountry");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryNameIdCustomerCountry",
                table: "CustomerRegions",
                column: "CustomerCountryNameIdCustomerCountry",
                principalTable: "CustomerCountries",
                principalColumn: "IdCustomerCountry",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
