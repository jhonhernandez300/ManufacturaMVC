using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class CustomerCities
    {
        [Key]
        public int IdCustomerCity { get; set; }
        public string CustomerCityName { get; set; }

        public int PostalCode { get; set; }

        [ForeignKey("IdCustomerRegion")]
        public int IdCustomerRegion { get; set; }
        public CustomerRegions CustomerRegion { get; set; }

        public ICollection<Customers> Customers { get; set; }


    }
}
