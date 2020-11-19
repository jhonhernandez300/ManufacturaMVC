using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Dto
{
    public class CustomerRegionsDto
    {
        public int IdCustomerRegion { get; set; }
        public string CustomerRegionName { get; set; }
               
        public int IdCustomerCountry { get; set; }
        public CustomerCountriesDto CustomerCountryDto { get; set; }

        //public ICollection<CustomerCitiesDto> CustomerCitiesDto { get; set; }
    }
}
