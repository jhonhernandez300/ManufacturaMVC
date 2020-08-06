using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class CustomerCountryNamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRegions_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "CustomerCountryIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "CustomerCountry",
                table: "CustomerCountries");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCountryNameIdCustomerCountry",
                table: "CustomerRegions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCountryName",
                table: "CustomerCountries",
                maxLength: 50,
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CustomerCountryName",
                table: "CustomerCountries");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCountryIdCustomerCountry",
                table: "CustomerRegions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCountry",
                table: "CustomerCountries",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions",
                column: "CustomerCountryIdCustomerCountry");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions",
                column: "CustomerCountryIdCustomerCountry",
                principalTable: "CustomerCountries",
                principalColumn: "IdCustomerCountry",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
