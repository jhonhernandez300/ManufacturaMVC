using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class CustomerCountriesconId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountry1",
                table: "CustomerRegions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRegions_CustomerCountry1",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries");

            migrationBuilder.DropColumn(
                name: "CustomerCountry1",
                table: "CustomerRegions");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCountryId",
                table: "CustomerRegions",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCountry",
                table: "CustomerCountries",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerCountries",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_CustomerCountryId",
                table: "CustomerRegions",
                column: "CustomerCountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryId",
                table: "CustomerRegions",
                column: "CustomerCountryId",
                principalTable: "CustomerCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryId",
                table: "CustomerRegions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRegions_CustomerCountryId",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries");

            migrationBuilder.DropColumn(
                name: "CustomerCountryId",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerCountries");

            migrationBuilder.AddColumn<string>(
                name: "CustomerCountry1",
                table: "CustomerRegions",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCountry",
                table: "CustomerCountries",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCountries",
                table: "CustomerCountries",
                column: "CustomerCountry");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_CustomerCountry1",
                table: "CustomerRegions",
                column: "CustomerCountry1");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountry1",
                table: "CustomerRegions",
                column: "CustomerCountry1",
                principalTable: "CustomerCountries",
                principalColumn: "CustomerCountry",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
