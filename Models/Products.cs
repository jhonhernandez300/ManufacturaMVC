using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int QuantityPerUnit { get; set; }

        public double UnitPrice { get; set; }

        public string PicturePath { get; set; }

        public string Notes { get; set; }

        public ProductDetails ProductDetail { get; set; }

        public ProductionOrders ProductionOrder { get; set; }

        public Categories Category { get; set; }

        public Employees Employee { get; set; }

    }
}
