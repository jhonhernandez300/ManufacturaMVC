using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class SuplierCountries
    {
        [Key]
        public string SuplierCountry { get; set; }

        public ICollection<SuplierRegions> SuplierRegions { get; set; }


    }
}
