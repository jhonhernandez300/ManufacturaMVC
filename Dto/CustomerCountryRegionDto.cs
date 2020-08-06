using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Dto
{
    public class CustomerCountryRegionDto
    {
        public int IdCustomerRegion { get; set; }

        public string CustomerRegion { get; set; }

        public int IdCustomerCountry { get; set; }

        public string CustomerCountry { get; set; }
    }
}
