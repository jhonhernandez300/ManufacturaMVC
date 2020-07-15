using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.ViewModels
{
    public class CustomerCountriesDto
    {
        public int Id { get; set; }
        public string CustomerCountry { get; set; }

        public ICollection<CustomerRegionsDto> CustomerRegionsDto { get; set; }
    }
}
