using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.ViewModels
{
    public class CustomerCountryRegionDto
    {
        public int CustomerRegionId { get; set; }

        public string CustomerRegion { get; set; }

        public int CustomerCountryId { get; set; }

        public string CustomerCountry { get; set; }
        
    }
}
