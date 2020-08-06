using ManufacturaMVC.ViewModels;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<CustomerCities> CustomerCities { get; set; }
        public DbSet<CustomerCountries> CustomerCountries { get; set; }
        public DbSet<CustomerRegions> CustomerRegions { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<ProductionOrders> ProductionOrders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<RawMaterials> RawMaterials { get; set; }
        public DbSet<SaleInvoices> SaleInvoices { get; set; }
        public DbSet<Shippings> Shippings { get; set; }
        public DbSet<SuplierCities> SuplierCities { get; set; }
        public DbSet<SuplierCountries> SuplierCountries { get; set; }
        public DbSet<SuplierInvoices> SuplierInvoices { get; set; }
        public DbSet<SuplierRegions> SuplierRegions { get; set; }
        public DbSet<Supliers> Supliers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasKey(m => m.Id);
            modelBuilder.Entity<CustomerCities>().HasKey(m => m.Id);
            modelBuilder.Entity<CustomerCountries>().HasKey(m => m.IdCustomerCountry);
            modelBuilder.Entity<CustomerRegions>().HasKey(m => m.IdCustomerRegion);
            modelBuilder.Entity<Customers>().HasKey(m => m.Id);
            modelBuilder.Entity<Employees>().HasKey(m => m.Id);
            modelBuilder.Entity<Payments>().HasKey(m => m.Id);
            modelBuilder.Entity<ProductDetails>().HasKey(m => m.Id);
            modelBuilder.Entity<ProductionOrders>().HasKey(m => m.Id);
            modelBuilder.Entity<Products>().HasKey(m => m.Id);
            modelBuilder.Entity<RawMaterials>().HasKey(m => m.Id);
            modelBuilder.Entity<SaleInvoices>().HasKey(m => m.Id);
            modelBuilder.Entity<Shippings>().HasKey(m => m.Id);
            modelBuilder.Entity<SuplierCities>().HasKey(m => m.Id);
            modelBuilder.Entity<SuplierCountries>().HasKey(m => m.Id);
            modelBuilder.Entity<SuplierInvoices>().HasKey(m => m.Id);
            modelBuilder.Entity<SuplierRegions>().HasKey(m => m.Id);
            modelBuilder.Entity<Supliers>().HasKey(m => m.Id);
            
            modelBuilder.Entity<Products>()
            .HasOne(p => p.Category)
            .WithMany(b => b.Products);

            modelBuilder.Entity<CustomerRegions>()
           .HasOne(p => p.CustomerCountry)
           .WithMany(b => b.CustomerRegions)
           .HasForeignKey(t => t.IdCustomerCountry);

            modelBuilder.Entity<CustomerCities>()
           .HasOne(p => p.CustomerRegion)
           .WithMany(b => b.CustomerCities);

            modelBuilder.Entity<Customers>()
           .HasOne(p => p.CustomerCity)
           .WithMany(b => b.Customers);

            modelBuilder.Entity<SaleInvoices>()
           .HasOne(p => p.Customer)
           .WithMany(b => b.SaleInvoices);

            modelBuilder.Entity<Payments>()
           .HasOne(p => p.SaleInvoice)
           .WithMany(b => b.Payments);

            modelBuilder.Entity<ProductDetails>()
           .HasOne(p => p.SaleInvoice)
           .WithMany(b => b.ProductDetails);

            modelBuilder.Entity<Products>()
           .HasOne(p => p.ProductDetail)
           .WithMany(b => b.Products);

            modelBuilder.Entity<Products>()
           .HasOne(p => p.ProductionOrder)
           .WithMany(b => b.Products);

            modelBuilder.Entity<Products>()
           .HasOne(p => p.Employee)
           .WithMany(b => b.Products);

            modelBuilder.Entity<Products>()
           .HasOne(p => p.Category)
           .WithMany(b => b.Products);

            modelBuilder.Entity<ProductionOrders>()
           .HasOne(p => p.RawMaterial)
           .WithMany(b => b.ProductionOrders);

            modelBuilder.Entity<SuplierInvoices>()
           .HasOne(p => p.RawMaterial)
           .WithMany(b => b.SuplierInvoices);

            modelBuilder.Entity<SuplierInvoices>()
           .HasOne(p => p.Suplier)
           .WithMany(b => b.SuplierInvoices);

            /*modelBuilder.Entity<SuplierInvoices>()
            .HasRequired(p => p.Shipping)
            .WithRequiredPrincipal(b => b.SuplierInvoice); */

            modelBuilder.Entity<SuplierInvoices>()
            .HasOne(a => a.Shipping)
            .WithOne(b => b.SuplierInvoice)
            .HasForeignKey<Shippings>(b => b.SuplierInvoicesRef);

            modelBuilder.Entity<Supliers>()
           .HasOne(p => p.SuplierCity)
           .WithMany(b => b.Supliers);

            modelBuilder.Entity<SuplierCities>()
           .HasOne(p => p.SuplierRegion)
           .WithMany(b => b.SuplierCities);

            modelBuilder.Entity<SuplierRegions>()
           .HasOne(p => p.SuplierCountry)
           .WithMany(b => b.SuplierRegions);

            base.OnModelCreating(modelBuilder);
        }

    }
}
