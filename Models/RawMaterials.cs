using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class RawMaterials
    {
        [Key]
        public int RawMaterialsId { get; set; }

        public int Amount { get; set; }

        public decimal TotalCost { get; set; }

        public string Description { get; set; }

        public ICollection<ProductionOrders> ProductionOrders { get; set; }

        public ICollection<SuplierInvoices> SuplierInvoices { get; set; }
    }
}
