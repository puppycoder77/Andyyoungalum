using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyYoungAlumDataLib
{
    public class Waybill
    {
        public int WaybillId { get; set; }
        public int WaybillNum { get; set; }
        public int WaybillSerial { get; set; }
        public string GoodsDesc { get; set; }
        public string Guage { get; set; }
        public string SizeMIM { get; set; }
        public string Colour { get; set; }
        public int Quantity { get; set; }
        public string TotalMTSorKG { get; set; }

        public string SuppliedBy { get; set; }
        public string SupplierSignature { get; set; }
        public DateTime DateSupplied { get; set; }
        public string VehicleRegNum { get; set; }
        public string ReceivedBy { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverSignature { get; set; }
        public DateTime DateReceived { get; set; }


        public Customer Customer { get; set; }
    }
}
