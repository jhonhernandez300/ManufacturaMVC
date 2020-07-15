using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class SuplierCities
    {
        [Key]
        public int Id { get; set; }

        public string SuplierCity { get; set; }

        public int PostalCode { get; set; }


        public SuplierRegions SuplierRegion { get; set; }

        public ICollection<Supliers> Supliers { get; set; }
    }
}
