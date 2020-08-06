using ManufacturaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.ViewModels
{
    public class CustomerCountryRegionVM
    {
        public int IdCustomerRegion { get; set; }

        public string CustomerRegionName{ get; set; }

        public int IdCustomerCountry { get; set; }        
        
        public string CustomerCountryName { get; set; }


    }
}
