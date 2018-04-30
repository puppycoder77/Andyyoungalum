using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyYoungAlumDataLib
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public int ReceiptNum { get; set; }
        public Customer Customer { get; set; }
    }
}
