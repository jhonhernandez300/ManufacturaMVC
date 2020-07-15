using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturaMVC.Models
{
    public class Shippings
    {
        [Key]
        public int Id { get; set; }

        public DateTime InitialDateAndTime { get; set; }

        public DateTime DeliveryDateAndTime { get; set; }

        public SuplierInvoices SuplierInvoice { get; set; }

        public int SuplierInvoicesRef { get; set; }


    }
}
