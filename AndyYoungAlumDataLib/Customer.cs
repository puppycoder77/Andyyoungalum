using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AndyYoungAlumDataLib
{
    
    public class Customer
    {
        public Customer()
        {
            Invoices = new List<Invoice>();
            Waybills = new List<Waybill>();
            Receipts = new List<Receipt>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public virtual List<Invoice> Invoices { get; set; }
        public virtual List<Waybill> Waybills { get; set; }
        public virtual List<Receipt> Receipts { get; set; }
    }
}
