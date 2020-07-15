using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class SaleInvoices
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateAndTime { get; set; }

        public decimal Tax { get; set; }

        public string Notes { get; set; }

        public decimal Value { get; set; }

        public Customers Customer { get; set; }

        public ICollection<ProductDetails> ProductDetails { get; set; }

        public ICollection<Payments> Payments { get; set; }
    }
}
