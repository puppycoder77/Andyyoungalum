using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyYoungAlumDataLib
{
    public class PlainCoil
    {
        public int PlainCoilId { get; set; }

        [Display(Name = "Arrival Date")]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Container Or WayBill No")]
        public string ContainerOrWayBillNo { get; set; }

        public string Size { get; set; }

        [Display(Name = "Net Kg")]
        public int NetKg { get; set; }

        [Display(Name = "Actual Kg")]
        public int ActualKg { get; set; }

        public int Difference { get; set; }

        [Display(Name = "Coil Number")]
        public string CoilNo { get; set; }

        [Display(Name = "Date Of Product")]
        public string DateOfProduct { get; set; }

        [Display(Name = "Product Color")]
        public string ProductColor { get; set; }

        [Display(Name = "TPO NO")]
        public int TPONum { get; set; }

        [Display(Name = "Part A")]
        public string PartA { get; set; }

        [Display(Name = "Part B")]
        public string PartB { get; set; }

        [Display(Name = "Part C")]
        public string PartC { get; set; }

        [Display(Name = "Sold to")]
        public string SoldTo { get; set; }
    }
}
