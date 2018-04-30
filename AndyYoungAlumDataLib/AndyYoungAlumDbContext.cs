using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyYoungAlumDataLib
{
    public class AndyYoungAlumDbContext : DbContext
    {
        public AndyYoungAlumDbContext()
            : base(nameOrConnectionString: "AndyYoungAlumConnString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Waybill> Waybills { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<PlainCoil> PlainCoils { get; set; }
        public DbSet<SiteUser> SiteUsers { get; set; }
    }
}
