using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class ProductionOrders
    {
        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }

        public decimal TotalCost { get; set; }

        public decimal UnitCost { get; set; }

        public RawMaterials RawMaterial { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
