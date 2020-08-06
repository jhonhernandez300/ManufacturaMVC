using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class modificacióndeliddeCustomerCountryyCustomerRegion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegionId",
                table: "CustomerCities");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryID",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRegions_CustomerCountryID",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCities_CustomerRegionId",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "CustomerCountryID",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerCountries");

            migrationBuilder.DropColumn(
                name: "CustomerRegionId",
                table: "CustomerCities");

            migrationBuilder.AddColumn<int>(
                name: "IdCustomerRegion",
                table: "CustomerRegions",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCountryIdCustomerCountry",
                table: "CustomerRegions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCustomerCountry",
                table: "CustomerRegions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCustomerCountry",
                table: "CustomerCountries",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerRegionIdCustomerRegion",
                table: "CustomerCities",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions",
                column: "IdCustomerRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries",
                column: "IdCustomerCountry");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions",
                column: "CustomerCountryIdCustomerCountry");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions",
                column: "CustomerCountryIdCustomerCountry",
                principalTable: "CustomerCountries",
                principalColumn: "IdCustomerCountry",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegionIdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRegions_CustomerCountryIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCities_CustomerRegionIdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "IdCustomerRegion",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "CustomerCountryIdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "IdCustomerCountry",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "IdCustomerCountry",
                table: "CustomerCountries");

            migrationBuilder.DropColumn(
                name: "CustomerRegionIdCustomerRegion",
                table: "CustomerCities");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerRegions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCountryID",
                table: "CustomerRegions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerCountries",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerRegionId",
                table: "CustomerCities",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_CustomerCountryID",
                table: "CustomerRegions",
                column: "CustomerCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCities_CustomerRegionId",
                table: "CustomerCities",
                column: "CustomerRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegionId",
                table: "CustomerCities",
                column: "CustomerRegionId",
                principalTable: "CustomerRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryID",
                table: "CustomerRegions",
                column: "CustomerCountryID",
                principalTable: "CustomerCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
