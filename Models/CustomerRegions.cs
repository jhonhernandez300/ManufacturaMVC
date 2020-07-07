using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class CustomerRegions
    {
        [Key]
        [StringLength(50, ErrorMessage = "Longitud máxima para la región: 50")]
        public string CustomerRegion { get; set; }

        public CustomerCountries CustomerCountry { get; set; }

        public ICollection<CustomerCities> CustomerCities { get; set; }
    }
}
