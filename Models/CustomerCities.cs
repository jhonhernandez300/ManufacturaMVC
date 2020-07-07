using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class CustomerCities
    {
        [Key]
        public string CustomerCity { get; set; }

        public int PostalCode { get; set; }

        public CustomerRegions CustomerRegion { get; set; }

        public ICollection<Customers> Customers { get; set; }


    }
}
