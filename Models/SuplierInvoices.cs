using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class SuplierInvoices
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateAndTime { get; set; }

        public decimal Tax { get; set; }

        public string Notes { get; set; }

        public decimal Value { get; set; }

        public RawMaterials RawMaterial { get; set; }

        public Supliers Suplier { get; set; }

        public Shippings Shipping { get; set; }

    }
}
