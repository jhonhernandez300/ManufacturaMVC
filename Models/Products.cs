using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(50, ErrorMessage = "Longitud máxima para el nombre del producto es 50")]
        public string ProductName { get; set; }

        [StringLength(100, ErrorMessage = "Longitud máxima para la descripción es 100")]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero entre 1 y 2147483647")]
        public int QuantityPerUnit { get; set; }

        [Range(0.1, double.MaxValue, ErrorMessage = "Debe ser un número decimal entre 0.1 y 1.7976931348623157E+308")]
        public double UnitPrice { get; set; }

        [StringLength(50, ErrorMessage = "Longitud máxima la ubicación del imagen es 50")]
        public string PicturePath { get; set; }

        [StringLength(100, ErrorMessage = "Longitud máxima para las notas es 100")]
        public string Notes { get; set; }


        [ForeignKey("IdProductDetail")]
        public int IdProductDetail { get; set; }
        public ProductDetails ProductDetail { get; set; }


        [ForeignKey("IdProductionOrder")]
        public int IdProductionOrder { get; set; }
        public ProductionOrders ProductionOrder { get; set; }


        [ForeignKey("IdCategory")]
        public int IdCategory { get; set; }
        public Categories Category { get; set; }


        [ForeignKey("IdEmployee")]
        public int IdEmployee { get; set; }
        public Employees Employee { get; set; }

    }
}
