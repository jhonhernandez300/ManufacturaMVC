using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class CustomerRegions
    {
        [Key]
        public int IdCustomerRegion { get; set; }

        [StringLength(50, ErrorMessage = "Longitud máxima para la región: 50")]
        public string CustomerRegionName { get; set; }


        [ForeignKey("IdCustomerCountry")]
        public int IdCustomerCountry { get; set; }
        public CustomerCountries CustomerCountry { get; set; }
        
        public ICollection<CustomerCities> CustomerCities { get; set; }
    }
}
