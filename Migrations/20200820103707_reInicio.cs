using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class reInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerCities_CustomerCityId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerCityId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "CustomerCityId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerCities");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCityIdCustomerCity",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCustomerCity",
                table: "CustomerCities",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities",
                column: "IdCustomerCity");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerCityIdCustomerCity",
                table: "Customers",
                column: "CustomerCityIdCustomerCity");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerCities_CustomerCityIdCustomerCity",
                table: "Customers",
                column: "CustomerCityIdCustomerCity",
                principalTable: "CustomerCities",
                principalColumn: "IdCustomerCity",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerCities_CustomerCityIdCustomerCity",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerCityIdCustomerCity",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "CustomerCityIdCustomerCity",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IdCustomerCity",
                table: "CustomerCities");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCityId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerCities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerCityId",
                table: "Customers",
                column: "CustomerCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerCities_CustomerCityId",
                table: "Customers",
                column: "CustomerCityId",
                principalTable: "CustomerCities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
