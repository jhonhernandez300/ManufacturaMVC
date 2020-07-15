using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class Payments
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public DateTime DateAndTime { get; set; }

        public decimal Value { get; set; }

        public SaleInvoices SaleInvoice { get; set; }

    }
}
