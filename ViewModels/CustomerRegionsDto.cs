using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.ViewModels
{
    public class CustomerRegionsDto
    {
        public int Id { get; set; }
        public string CustomerRegion { get; set; }


        [ForeignKey("CustomerCountryIdDto")]
        public int CustomerCountryIdDto { get; set; }
        public CustomerCountriesDto CustomerCountryDto { get; set; }

        //public ICollection<CustomerCitiesDto> CustomerCitiesDto { get; set; }
        
    }
}
