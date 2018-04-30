namespace AndyYoungAlumDataLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceNum = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        NumberOfUnits = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ReceiptId = c.Int(nullable: false, identity: true),
                        ReceiptNum = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.ReceiptId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Waybills",
                c => new
                    {
                        WaybillId = c.Int(nullable: false, identity: true),
                        WaybillNum = c.Int(nullable: false),
                        WaybillSerial = c.Int(nullable: false),
                        GoodsDesc = c.String(),
                        Guage = c.String(),
                        SizeMIM = c.String(),
                        Colour = c.String(),
                        Quantity = c.Int(nullable: false),
                        TotalMTSorKG = c.String(),
                        SuppliedBy = c.String(),
                        SupplierSignature = c.String(),
                        DateSupplied = c.DateTime(nullable: false),
                        VehicleRegNum = c.String(),
                        ReceivedBy = c.String(),
                        ReceiverName = c.String(),
                        ReceiverSignature = c.String(),
                        DateReceived = c.DateTime(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.WaybillId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.PlainCoils",
                c => new
                    {
                        PlainCoilId = c.Int(nullable: false, identity: true),
                        ArrivalDate = c.DateTime(nullable: false),
                        ContainerOrWayBillNo = c.String(),
                        Size = c.String(),
                        NetKg = c.Int(nullable: false),
                        ActualKg = c.Int(nullable: false),
                        Difference = c.Int(nullable: false),
                        CoilNo = c.String(),
                        DateOfProduct = c.String(),
                        ProductColor = c.String(),
                        TPONum = c.Int(nullable: false),
                        PartA = c.String(),
                        PartB = c.String(),
                        PartC = c.String(),
                        SoldTo = c.String(),
                    })
                .PrimaryKey(t => t.PlainCoilId);
            
            CreateTable(
                "dbo.SiteUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Waybills", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Receipts", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Invoices", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Waybills", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Receipts", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Invoices", new[] { "Customer_CustomerId" });
            DropTable("dbo.SiteUsers");
            DropTable("dbo.PlainCoils");
            DropTable("dbo.Waybills");
            DropTable("dbo.Receipts");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
        }
    }
}
