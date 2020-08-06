using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Dto
{
    public class CustomerCountriesDto
    {
        public int IdCustomerCountry { get; set; }
        public string CustomerCountryName { get; set; }

        public ICollection<CustomerRegionsDto> CustomerRegionsDto { get; set; }

    }
}
