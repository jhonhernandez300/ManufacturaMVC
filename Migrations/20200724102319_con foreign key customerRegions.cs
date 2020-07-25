using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class conforeignkeycustomerRegions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryId",
                table: "CustomerRegions");

            migrationBuilder.RenameColumn(
                name: "CustomerCountryId",
                table: "CustomerRegions",
                newName: "CustomerCountryID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRegions_CustomerCountryId",
                table: "CustomerRegions",
                newName: "IX_CustomerRegions_CustomerCountryID");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerCountryID",
                table: "CustomerRegions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryID",
                table: "CustomerRegions",
                column: "CustomerCountryID",
                principalTable: "CustomerCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryID",
                table: "CustomerRegions");

            migrationBuilder.RenameColumn(
                name: "CustomerCountryID",
                table: "CustomerRegions",
                newName: "CustomerCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRegions_CustomerCountryID",
                table: "CustomerRegions",
                newName: "IX_CustomerRegions_CustomerCountryId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerCountryId",
                table: "CustomerRegions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRegions_CustomerCountries_CustomerCountryId",
                table: "CustomerRegions",
                column: "CustomerCountryId",
                principalTable: "CustomerCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
