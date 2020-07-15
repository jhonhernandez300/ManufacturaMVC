using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class Idpuestosparatodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegion1",
                table: "CustomerCities");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerCities_CustomerCity1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_SaleInvoices_SaleInvoiceId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_SaleInvoices_SaleInvoiceId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionOrders_RawMaterials_RawMaterialsId",
                table: "ProductionOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductDetails_ProductDetailsId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductionOrders_ProductionOrdersId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Shippings_SuplierInvoices_SuplierInvoicesRef",
                table: "Shippings");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierCities_SuplierRegions_SuplierRegion1",
                table: "SuplierCities");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierInvoices_RawMaterials_RawMaterialsId",
                table: "SuplierInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierInvoices_Supliers_SuplierId",
                table: "SuplierInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierRegions_SuplierCountries_SuplierCountry1",
                table: "SuplierRegions");

            migrationBuilder.DropForeignKey(
                name: "FK_Supliers_SuplierCities_SuplierCity1",
                table: "Supliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supliers",
                table: "Supliers");

            migrationBuilder.DropIndex(
                name: "IX_Supliers_SuplierCity1",
                table: "Supliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierRegions",
                table: "SuplierRegions");

            migrationBuilder.DropIndex(
                name: "IX_SuplierRegions_SuplierCountry1",
                table: "SuplierRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierInvoices",
                table: "SuplierInvoices");

            migrationBuilder.DropIndex(
                name: "IX_SuplierInvoices_RawMaterialsId",
                table: "SuplierInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierCountries",
                table: "SuplierCountries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierCities",
                table: "SuplierCities");

            migrationBuilder.DropIndex(
                name: "IX_SuplierCities_SuplierRegion1",
                table: "SuplierCities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shippings",
                table: "Shippings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleInvoices",
                table: "SaleInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RawMaterials",
                table: "RawMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductDetailsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductionOrdersId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionOrders",
                table: "ProductionOrders");

            migrationBuilder.DropIndex(
                name: "IX_ProductionOrders_RawMaterialsId",
                table: "ProductionOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerCity1",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCities_CustomerRegion1",
                table: "CustomerCities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SuplierId",
                table: "Supliers");

            migrationBuilder.DropColumn(
                name: "SuplierCity1",
                table: "Supliers");

            migrationBuilder.DropColumn(
                name: "SuplierCountry1",
                table: "SuplierRegions");

            migrationBuilder.DropColumn(
                name: "SuplierInvoiceId",
                table: "SuplierInvoices");

            migrationBuilder.DropColumn(
                name: "RawMaterialsId",
                table: "SuplierInvoices");

            migrationBuilder.DropColumn(
                name: "SuplierRegion1",
                table: "SuplierCities");

            migrationBuilder.DropColumn(
                name: "ShippingId",
                table: "Shippings");

            migrationBuilder.DropColumn(
                name: "SaleInvoiceId",
                table: "SaleInvoices");

            migrationBuilder.DropColumn(
                name: "RawMaterialsId",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductionOrdersId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductionOrdersId",
                table: "ProductionOrders");

            migrationBuilder.DropColumn(
                name: "RawMaterialsId",
                table: "ProductionOrders");

            migrationBuilder.DropColumn(
                name: "ProductDetailsId",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerCity1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerRegion1",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Supliers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SuplierCityId",
                table: "Supliers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SuplierRegion",
                table: "SuplierRegions",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SuplierRegions",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SuplierCountryId",
                table: "SuplierRegions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SuplierInvoices",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RawMaterialId",
                table: "SuplierInvoices",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SuplierCountry",
                table: "SuplierCountries",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SuplierCountries",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SuplierCity",
                table: "SuplierCities",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SuplierCities",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SuplierRegionId",
                table: "SuplierCities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Shippings",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SaleInvoices",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RawMaterials",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Products",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductionOrderId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductionOrders",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RawMaterialId",
                table: "ProductionOrders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductDetails",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Payments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employees",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Customers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCityId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerRegion",
                table: "CustomerRegions",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerRegions",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCity",
                table: "CustomerCities",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CustomerCities",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerRegionId",
                table: "CustomerCities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Categories",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supliers",
                table: "Supliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierRegions",
                table: "SuplierRegions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierInvoices",
                table: "SuplierInvoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierCountries",
                table: "SuplierCountries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierCities",
                table: "SuplierCities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shippings",
                table: "Shippings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleInvoices",
                table: "SaleInvoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RawMaterials",
                table: "RawMaterials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionOrders",
                table: "ProductionOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Supliers_SuplierCityId",
                table: "Supliers",
                column: "SuplierCityId");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierRegions_SuplierCountryId",
                table: "SuplierRegions",
                column: "SuplierCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierInvoices_RawMaterialId",
                table: "SuplierInvoices",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierCities_SuplierRegionId",
                table: "SuplierCities",
                column: "SuplierRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDetailId",
                table: "Products",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductionOrderId",
                table: "Products",
                column: "ProductionOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrders_RawMaterialId",
                table: "ProductionOrders",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerCityId",
                table: "Customers",
                column: "CustomerCityId");

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
                name: "FK_Customers_CustomerCities_CustomerCityId",
                table: "Customers",
                column: "CustomerCityId",
                principalTable: "CustomerCities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_SaleInvoices_SaleInvoiceId",
                table: "Payments",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_SaleInvoices_SaleInvoiceId",
                table: "ProductDetails",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionOrders_RawMaterials_RawMaterialId",
                table: "ProductionOrders",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductDetails_ProductDetailId",
                table: "Products",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductionOrders_ProductionOrderId",
                table: "Products",
                column: "ProductionOrderId",
                principalTable: "ProductionOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shippings_SuplierInvoices_SuplierInvoicesRef",
                table: "Shippings",
                column: "SuplierInvoicesRef",
                principalTable: "SuplierInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierCities_SuplierRegions_SuplierRegionId",
                table: "SuplierCities",
                column: "SuplierRegionId",
                principalTable: "SuplierRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierInvoices_RawMaterials_RawMaterialId",
                table: "SuplierInvoices",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierInvoices_Supliers_SuplierId",
                table: "SuplierInvoices",
                column: "SuplierId",
                principalTable: "Supliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierRegions_SuplierCountries_SuplierCountryId",
                table: "SuplierRegions",
                column: "SuplierCountryId",
                principalTable: "SuplierCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supliers_SuplierCities_SuplierCityId",
                table: "Supliers",
                column: "SuplierCityId",
                principalTable: "SuplierCities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegionId",
                table: "CustomerCities");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerCities_CustomerCityId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_SaleInvoices_SaleInvoiceId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_SaleInvoices_SaleInvoiceId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionOrders_RawMaterials_RawMaterialId",
                table: "ProductionOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductDetails_ProductDetailId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductionOrders_ProductionOrderId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Shippings_SuplierInvoices_SuplierInvoicesRef",
                table: "Shippings");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierCities_SuplierRegions_SuplierRegionId",
                table: "SuplierCities");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierInvoices_RawMaterials_RawMaterialId",
                table: "SuplierInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierInvoices_Supliers_SuplierId",
                table: "SuplierInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SuplierRegions_SuplierCountries_SuplierCountryId",
                table: "SuplierRegions");

            migrationBuilder.DropForeignKey(
                name: "FK_Supliers_SuplierCities_SuplierCityId",
                table: "Supliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supliers",
                table: "Supliers");

            migrationBuilder.DropIndex(
                name: "IX_Supliers_SuplierCityId",
                table: "Supliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierRegions",
                table: "SuplierRegions");

            migrationBuilder.DropIndex(
                name: "IX_SuplierRegions_SuplierCountryId",
                table: "SuplierRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierInvoices",
                table: "SuplierInvoices");

            migrationBuilder.DropIndex(
                name: "IX_SuplierInvoices_RawMaterialId",
                table: "SuplierInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierCountries",
                table: "SuplierCountries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuplierCities",
                table: "SuplierCities");

            migrationBuilder.DropIndex(
                name: "IX_SuplierCities_SuplierRegionId",
                table: "SuplierCities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shippings",
                table: "Shippings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleInvoices",
                table: "SaleInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RawMaterials",
                table: "RawMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductDetailId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductionOrderId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionOrders",
                table: "ProductionOrders");

            migrationBuilder.DropIndex(
                name: "IX_ProductionOrders_RawMaterialId",
                table: "ProductionOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerCityId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities");

            migrationBuilder.DropIndex(
                name: "IX_CustomerCities_CustomerRegionId",
                table: "CustomerCities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Supliers");

            migrationBuilder.DropColumn(
                name: "SuplierCityId",
                table: "Supliers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SuplierRegions");

            migrationBuilder.DropColumn(
                name: "SuplierCountryId",
                table: "SuplierRegions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SuplierInvoices");

            migrationBuilder.DropColumn(
                name: "RawMaterialId",
                table: "SuplierInvoices");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SuplierCountries");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SuplierCities");

            migrationBuilder.DropColumn(
                name: "SuplierRegionId",
                table: "SuplierCities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Shippings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SaleInvoices");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductionOrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductionOrders");

            migrationBuilder.DropColumn(
                name: "RawMaterialId",
                table: "ProductionOrders");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerCityId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerRegions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "CustomerRegionId",
                table: "CustomerCities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "SuplierId",
                table: "Supliers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "SuplierCity1",
                table: "Supliers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SuplierRegion",
                table: "SuplierRegions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuplierCountry1",
                table: "SuplierRegions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SuplierInvoiceId",
                table: "SuplierInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RawMaterialsId",
                table: "SuplierInvoices",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SuplierCountry",
                table: "SuplierCountries",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SuplierCity",
                table: "SuplierCities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuplierRegion1",
                table: "SuplierCities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShippingId",
                table: "Shippings",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SaleInvoiceId",
                table: "SaleInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RawMaterialsId",
                table: "RawMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailsId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductionOrdersId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductionOrdersId",
                table: "ProductionOrders",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RawMaterialsId",
                table: "ProductionOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailsId",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CustomerCity1",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerRegion",
                table: "CustomerRegions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCity",
                table: "CustomerCities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerRegion1",
                table: "CustomerCities",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supliers",
                table: "Supliers",
                column: "SuplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierRegions",
                table: "SuplierRegions",
                column: "SuplierRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierInvoices",
                table: "SuplierInvoices",
                column: "SuplierInvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierCountries",
                table: "SuplierCountries",
                column: "SuplierCountry");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuplierCities",
                table: "SuplierCities",
                column: "SuplierCity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shippings",
                table: "Shippings",
                column: "ShippingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleInvoices",
                table: "SaleInvoices",
                column: "SaleInvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RawMaterials",
                table: "RawMaterials",
                column: "RawMaterialsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionOrders",
                table: "ProductionOrders",
                column: "ProductionOrdersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails",
                column: "ProductDetailsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRegions",
                table: "CustomerRegions",
                column: "CustomerRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCities",
                table: "CustomerCities",
                column: "CustomerCity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Supliers_SuplierCity1",
                table: "Supliers",
                column: "SuplierCity1");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierRegions_SuplierCountry1",
                table: "SuplierRegions",
                column: "SuplierCountry1");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierInvoices_RawMaterialsId",
                table: "SuplierInvoices",
                column: "RawMaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierCities_SuplierRegion1",
                table: "SuplierCities",
                column: "SuplierRegion1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDetailsId",
                table: "Products",
                column: "ProductDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductionOrdersId",
                table: "Products",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrders_RawMaterialsId",
                table: "ProductionOrders",
                column: "RawMaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerCity1",
                table: "Customers",
                column: "CustomerCity1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCities_CustomerRegion1",
                table: "CustomerCities",
                column: "CustomerRegion1");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCities_CustomerRegions_CustomerRegion1",
                table: "CustomerCities",
                column: "CustomerRegion1",
                principalTable: "CustomerRegions",
                principalColumn: "CustomerRegion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerCities_CustomerCity1",
                table: "Customers",
                column: "CustomerCity1",
                principalTable: "CustomerCities",
                principalColumn: "CustomerCity",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_SaleInvoices_SaleInvoiceId",
                table: "Payments",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "SaleInvoiceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_SaleInvoices_SaleInvoiceId",
                table: "ProductDetails",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "SaleInvoiceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionOrders_RawMaterials_RawMaterialsId",
                table: "ProductionOrders",
                column: "RawMaterialsId",
                principalTable: "RawMaterials",
                principalColumn: "RawMaterialsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductDetails_ProductDetailsId",
                table: "Products",
                column: "ProductDetailsId",
                principalTable: "ProductDetails",
                principalColumn: "ProductDetailsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductionOrders_ProductionOrdersId",
                table: "Products",
                column: "ProductionOrdersId",
                principalTable: "ProductionOrders",
                principalColumn: "ProductionOrdersId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shippings_SuplierInvoices_SuplierInvoicesRef",
                table: "Shippings",
                column: "SuplierInvoicesRef",
                principalTable: "SuplierInvoices",
                principalColumn: "SuplierInvoiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierCities_SuplierRegions_SuplierRegion1",
                table: "SuplierCities",
                column: "SuplierRegion1",
                principalTable: "SuplierRegions",
                principalColumn: "SuplierRegion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierInvoices_RawMaterials_RawMaterialsId",
                table: "SuplierInvoices",
                column: "RawMaterialsId",
                principalTable: "RawMaterials",
                principalColumn: "RawMaterialsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierInvoices_Supliers_SuplierId",
                table: "SuplierInvoices",
                column: "SuplierId",
                principalTable: "Supliers",
                principalColumn: "SuplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuplierRegions_SuplierCountries_SuplierCountry1",
                table: "SuplierRegions",
                column: "SuplierCountry1",
                principalTable: "SuplierCountries",
                principalColumn: "SuplierCountry",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supliers_SuplierCities_SuplierCity1",
                table: "Supliers",
                column: "SuplierCity1",
                principalTable: "SuplierCities",
                principalColumn: "SuplierCity",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
