using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class ProductDetails
    {
        [Key]
        public int ProductDetailId { get; set; }

        [Range(0.1, double.MaxValue, ErrorMessage = "Debe ser un número decimal entre 0.1 y 1.7976931348623157E+308")]
        public double Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero entre 1 y 2147483647")]
        public int Quantity { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero entre 1 y 2147483647")]
        public int DiscountPercentage { get; set; }

        [ForeignKey("IdSaleInvoiceId")]
        public int IdSaleInvoiceId { get; set; }
        public SaleInvoices SaleInvoice { get; set; }


        public ICollection<Products> Products { get; set; }

    }
}
