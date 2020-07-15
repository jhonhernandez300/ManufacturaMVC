using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class SuplierRegions
    {
        [Key]
        public int Id { get; set; }

        public string SuplierRegion { get; set; }

        public SuplierCountries SuplierCountry { get; set; }

        public ICollection<SuplierCities> SuplierCities { get; set; }

    }
}
