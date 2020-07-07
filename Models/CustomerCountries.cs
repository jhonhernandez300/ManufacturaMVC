using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class CustomerCountries
    {
        [StringLength(50, ErrorMessage = "Longitud máxima para el país: 50")]
        public string CustomerCountry { get; set; }

        public ICollection<CustomerRegions> CustomerRegions { get; set; }
    }
}
