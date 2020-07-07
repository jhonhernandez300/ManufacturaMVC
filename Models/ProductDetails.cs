using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class ProductDetails
    {
        [Key]
        public int ProductDetailsId { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int DiscountPercentage { get; set; }

        public SaleInvoices SaleInvoice { get; set; }

        public ICollection<Products> Products { get; set; }

    }
}
