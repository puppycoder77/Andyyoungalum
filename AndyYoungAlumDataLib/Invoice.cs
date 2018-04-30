using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyYoungAlumDataLib
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public int InvoiceNum { get; set; }

        //The result of this will be later split into day, month and year on the client.
        public DateTime InvoiceDate { get; set; }


        [Display(Name = "NO OF UNITS")]
        public int NumberOfUnits { get; set; }

        [Required(ErrorMessage = "Description for the invoice is needed")]
        public string Description { get; set; }

        [Display(Name = "Unit Price")]
        [Required(ErrorMessage="Unit Price is required")]
        public int UnitPrice { get; set; }

        [Display(Name = "Total Amount")]
        public int TotalAmount { get; set; }

        
        //This will be used to populate the name area of the invoice.
        public Customer Customer { get; set; }

    }
}
