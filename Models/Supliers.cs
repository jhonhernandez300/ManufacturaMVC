using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class Supliers
    {
        [Key]
        public int SuplierId { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string WebPage { get; set; }

        public string Notes { get; set; }

        public SuplierCities SuplierCity { get; set; }

        public ICollection<SuplierInvoices> SuplierInvoices { get; set; }

    }
}
