using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManufacturaMVC.Migrations
{
    public partial class i : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCountries",
                columns: table => new
                {
                    CustomerCountry = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCountries", x => x.CustomerCountry);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialsId);
                });

            migrationBuilder.CreateTable(
                name: "SuplierCountries",
                columns: table => new
                {
                    SuplierCountry = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuplierCountries", x => x.SuplierCountry);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRegions",
                columns: table => new
                {
                    CustomerRegion = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerCountry1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRegions", x => x.CustomerRegion);
                    table.ForeignKey(
                        name: "FK_CustomerRegions_CustomerCountries_CustomerCountry1",
                        column: x => x.CustomerCountry1,
                        principalTable: "CustomerCountries",
                        principalColumn: "CustomerCountry",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOrders",
                columns: table => new
                {
                    ProductionOrdersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: false),
                    UnitCost = table.Column<decimal>(nullable: false),
                    RawMaterialsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOrders", x => x.ProductionOrdersId);
                    table.ForeignKey(
                        name: "FK_ProductionOrders_RawMaterials_RawMaterialsId",
                        column: x => x.RawMaterialsId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuplierRegions",
                columns: table => new
                {
                    SuplierRegion = table.Column<string>(nullable: false),
                    SuplierCountry1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuplierRegions", x => x.SuplierRegion);
                    table.ForeignKey(
                        name: "FK_SuplierRegions_SuplierCountries_SuplierCountry1",
                        column: x => x.SuplierCountry1,
                        principalTable: "SuplierCountries",
                        principalColumn: "SuplierCountry",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCities",
                columns: table => new
                {
                    CustomerCity = table.Column<string>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    CustomerRegion1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCities", x => x.CustomerCity);
                    table.ForeignKey(
                        name: "FK_CustomerCities_CustomerRegions_CustomerRegion1",
                        column: x => x.CustomerRegion1,
                        principalTable: "CustomerRegions",
                        principalColumn: "CustomerRegion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuplierCities",
                columns: table => new
                {
                    SuplierCity = table.Column<string>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    SuplierRegion1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuplierCities", x => x.SuplierCity);
                    table.ForeignKey(
                        name: "FK_SuplierCities_SuplierRegions_SuplierRegion1",
                        column: x => x.SuplierRegion1,
                        principalTable: "SuplierRegions",
                        principalColumn: "SuplierRegion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CustomerCity1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerCities_CustomerCity1",
                        column: x => x.CustomerCity1,
                        principalTable: "CustomerCities",
                        principalColumn: "CustomerCity",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supliers",
                columns: table => new
                {
                    SuplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WebPage = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    SuplierCity1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supliers", x => x.SuplierId);
                    table.ForeignKey(
                        name: "FK_Supliers_SuplierCities_SuplierCity1",
                        column: x => x.SuplierCity1,
                        principalTable: "SuplierCities",
                        principalColumn: "SuplierCity",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoices",
                columns: table => new
                {
                    SaleInvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Value = table.Column<decimal>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoices", x => x.SaleInvoiceId);
                    table.ForeignKey(
                        name: "FK_SaleInvoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuplierInvoices",
                columns: table => new
                {
                    SuplierInvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Value = table.Column<decimal>(nullable: false),
                    RawMaterialsId = table.Column<int>(nullable: true),
                    SuplierId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuplierInvoices", x => x.SuplierInvoiceId);
                    table.ForeignKey(
                        name: "FK_SuplierInvoices_RawMaterials_RawMaterialsId",
                        column: x => x.RawMaterialsId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuplierInvoices_Supliers_SuplierId",
                        column: x => x.SuplierId,
                        principalTable: "Supliers",
                        principalColumn: "SuplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    SaleInvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_SaleInvoices_SaleInvoiceId",
                        column: x => x.SaleInvoiceId,
                        principalTable: "SaleInvoices",
                        principalColumn: "SaleInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    DiscountPercentage = table.Column<int>(nullable: false),
                    SaleInvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetailsId);
                    table.ForeignKey(
                        name: "FK_ProductDetails_SaleInvoices_SaleInvoiceId",
                        column: x => x.SaleInvoiceId,
                        principalTable: "SaleInvoices",
                        principalColumn: "SaleInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shippings",
                columns: table => new
                {
                    ShippingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitialDateAndTime = table.Column<DateTime>(nullable: false),
                    DeliveryDateAndTime = table.Column<DateTime>(nullable: false),
                    SuplierInvoicesRef = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippings", x => x.ShippingId);
                    table.ForeignKey(
                        name: "FK_Shippings_SuplierInvoices_SuplierInvoicesRef",
                        column: x => x.SuplierInvoicesRef,
                        principalTable: "SuplierInvoices",
                        principalColumn: "SuplierInvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    QuantityPerUnit = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false),
                    PicturePath = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ProductDetailsId = table.Column<int>(nullable: true),
                    ProductionOrdersId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductDetails_ProductDetailsId",
                        column: x => x.ProductDetailsId,
                        principalTable: "ProductDetails",
                        principalColumn: "ProductDetailsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "ProductionOrdersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCities_CustomerRegion1",
                table: "CustomerCities",
                column: "CustomerRegion1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRegions_CustomerCountry1",
                table: "CustomerRegions",
                column: "CustomerCountry1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerCity1",
                table: "Customers",
                column: "CustomerCity1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SaleInvoiceId",
                table: "Payments",
                column: "SaleInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_SaleInvoiceId",
                table: "ProductDetails",
                column: "SaleInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrders_RawMaterialsId",
                table: "ProductionOrders",
                column: "RawMaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EmployeeId",
                table: "Products",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDetailsId",
                table: "Products",
                column: "ProductDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductionOrdersId",
                table: "Products",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoices_CustomerId",
                table: "SaleInvoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Shippings_SuplierInvoicesRef",
                table: "Shippings",
                column: "SuplierInvoicesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuplierCities_SuplierRegion1",
                table: "SuplierCities",
                column: "SuplierRegion1");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierInvoices_RawMaterialsId",
                table: "SuplierInvoices",
                column: "RawMaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierInvoices_SuplierId",
                table: "SuplierInvoices",
                column: "SuplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SuplierRegions_SuplierCountry1",
                table: "SuplierRegions",
                column: "SuplierCountry1");

            migrationBuilder.CreateIndex(
                name: "IX_Supliers_SuplierCity1",
                table: "Supliers",
                column: "SuplierCity1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shippings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductionOrders");

            migrationBuilder.DropTable(
                name: "SuplierInvoices");

            migrationBuilder.DropTable(
                name: "SaleInvoices");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "Supliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SuplierCities");

            migrationBuilder.DropTable(
                name: "CustomerCities");

            migrationBuilder.DropTable(
                name: "SuplierRegions");

            migrationBuilder.DropTable(
                name: "CustomerRegions");

            migrationBuilder.DropTable(
                name: "SuplierCountries");

            migrationBuilder.DropTable(
                name: "CustomerCountries");
        }
    }
}
