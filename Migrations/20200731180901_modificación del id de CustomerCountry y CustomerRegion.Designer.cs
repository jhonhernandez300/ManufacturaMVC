﻿// <auto-generated />
using System;
using ManufacturaMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManufacturaMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200731180901_modificación del id de CustomerCountry y CustomerRegion")]
    partial class modificacióndeliddeCustomerCountryyCustomerRegion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManufacturaMVC.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.CustomerCities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerRegionIdCustomerRegion")
                        .HasColumnType("int");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerRegionIdCustomerRegion");

                    b.ToTable("CustomerCities");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.CustomerCountries", b =>
                {
                    b.Property<int>("IdCustomerCountry")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerCountry")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdCustomerCountry");

                    b.ToTable("CustomerCountries");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.CustomerRegions", b =>
                {
                    b.Property<int>("IdCustomerRegion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerCountryIdCustomerCountry")
                        .HasColumnType("int");

                    b.Property<string>("CustomerRegion")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdCustomerCountry")
                        .HasColumnType("int");

                    b.HasKey("IdCustomerRegion");

                    b.HasIndex("CustomerCountryIdCustomerCountry");

                    b.ToTable("CustomerRegions");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerCityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerCityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Payments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SaleInvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SaleInvoiceId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.ProductDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SaleInvoiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SaleInvoiceId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.ProductionOrders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("RawMaterialId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("RawMaterialId");

                    b.ToTable("ProductionOrders");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductDetailId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductionOrderId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductDetailId");

                    b.HasIndex("ProductionOrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.RawMaterials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SaleInvoices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("SaleInvoices");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Shippings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeliveryDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitialDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuplierInvoicesRef")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuplierInvoicesRef")
                        .IsUnique();

                    b.ToTable("Shippings");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SuplierCities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("SuplierCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuplierRegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuplierRegionId");

                    b.ToTable("SuplierCities");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SuplierCountries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SuplierCountry")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SuplierCountries");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SuplierInvoices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RawMaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("SuplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("RawMaterialId");

                    b.HasIndex("SuplierId");

                    b.ToTable("SuplierInvoices");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SuplierRegions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SuplierCountryId")
                        .HasColumnType("int");

                    b.Property<string>("SuplierRegion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuplierCountryId");

                    b.ToTable("SuplierRegions");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Supliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuplierCityId")
                        .HasColumnType("int");

                    b.Property<string>("WebPage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuplierCityId");

                    b.ToTable("Supliers");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.CustomerCities", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.CustomerRegions", "CustomerRegion")
                        .WithMany("CustomerCities")
                        .HasForeignKey("CustomerRegionIdCustomerRegion");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.CustomerRegions", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.CustomerCountries", "CustomerCountry")
                        .WithMany("CustomerRegions")
                        .HasForeignKey("CustomerCountryIdCustomerCountry");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Customers", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.CustomerCities", "CustomerCity")
                        .WithMany("Customers")
                        .HasForeignKey("CustomerCityId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Payments", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.SaleInvoices", "SaleInvoice")
                        .WithMany("Payments")
                        .HasForeignKey("SaleInvoiceId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.ProductDetails", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.SaleInvoices", "SaleInvoice")
                        .WithMany("ProductDetails")
                        .HasForeignKey("SaleInvoiceId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.ProductionOrders", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.RawMaterials", "RawMaterial")
                        .WithMany("ProductionOrders")
                        .HasForeignKey("RawMaterialId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Products", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.Categories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ManufacturaMVC.Models.Employees", "Employee")
                        .WithMany("Products")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("ManufacturaMVC.Models.ProductDetails", "ProductDetail")
                        .WithMany("Products")
                        .HasForeignKey("ProductDetailId");

                    b.HasOne("ManufacturaMVC.Models.ProductionOrders", "ProductionOrder")
                        .WithMany("Products")
                        .HasForeignKey("ProductionOrderId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SaleInvoices", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.Customers", "Customer")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Shippings", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.SuplierInvoices", "SuplierInvoice")
                        .WithOne("Shipping")
                        .HasForeignKey("ManufacturaMVC.Models.Shippings", "SuplierInvoicesRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SuplierCities", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.SuplierRegions", "SuplierRegion")
                        .WithMany("SuplierCities")
                        .HasForeignKey("SuplierRegionId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SuplierInvoices", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.RawMaterials", "RawMaterial")
                        .WithMany("SuplierInvoices")
                        .HasForeignKey("RawMaterialId");

                    b.HasOne("ManufacturaMVC.Models.Supliers", "Suplier")
                        .WithMany("SuplierInvoices")
                        .HasForeignKey("SuplierId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.SuplierRegions", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.SuplierCountries", "SuplierCountry")
                        .WithMany("SuplierRegions")
                        .HasForeignKey("SuplierCountryId");
                });

            modelBuilder.Entity("ManufacturaMVC.Models.Supliers", b =>
                {
                    b.HasOne("ManufacturaMVC.Models.SuplierCities", "SuplierCity")
                        .WithMany("Supliers")
                        .HasForeignKey("SuplierCityId");
                });
#pragma warning restore 612, 618
        }
    }
}
