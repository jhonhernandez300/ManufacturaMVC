using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.ViewModels
{
    public class CustomerRegionCityVM
    {
        public int IdCustomerRegion { get; set; }

        public string CustomerRegionName { get; set; }

        public int IdCustomerCity { get; set; }

        public string CustomerCityName { get; set; }
    }
}
