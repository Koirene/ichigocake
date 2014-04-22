namespace ichigocake.persistenceEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cake",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsDecorative = c.Boolean(nullable: false),
                        PiePrice = c.Double(nullable: false),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Url = c.String(),
                        Type = c.Int(nullable: false),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Cake_Id = c.Int(),
                        Reference_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cake", t => t.Cake_Id)
                .ForeignKey("dbo.Reference", t => t.Reference_Id)
                .Index(t => t.Cake_Id)
                .Index(t => t.Reference_Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        MaxDaytoOrder = c.Int(nullable: false),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(),
                        Image_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Image", t => t.Image_Id)
                .Index(t => t.Image_Id);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.District",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Membership",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        CreateDate = c.DateTime(),
                        ConfirmationToken = c.String(maxLength: 128),
                        IsConfirmed = c.Boolean(),
                        LastPasswordFailureDate = c.DateTime(),
                        PasswordFailuresSinceLastSuccess = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 128),
                        PasswordChangedDate = c.DateTime(),
                        PasswordSalt = c.String(nullable: false, maxLength: 128),
                        PasswordVerificationToken = c.String(maxLength: 128),
                        PasswordVerificationTokenExpirationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Subject = c.String(),
                        MessageContent = c.String(),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        City_Id = c.Int(),
                        District_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.City_Id)
                .ForeignKey("dbo.District", t => t.District_Id)
                .Index(t => t.City_Id)
                .Index(t => t.District_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        TotalAmount = c.Double(nullable: false),
                        RequestedDateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Category_Id = c.Int(),
                        Delivery_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .ForeignKey("dbo.Delivery", t => t.Delivery_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Delivery_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.CakeOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Cake_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cake", t => t.Cake_Id)
                .ForeignKey("dbo.Order", t => t.Order_Id)
                .Index(t => t.Cake_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Delivery",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reference",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(),
                        BodyContent = c.String(),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Image", "Reference_Id", "dbo.Reference");
            DropForeignKey("dbo.Order", "User_Id", "dbo.User");
            DropForeignKey("dbo.Order", "Delivery_Id", "dbo.Delivery");
            DropForeignKey("dbo.Order", "Category_Id", "dbo.Category");
            DropForeignKey("dbo.CakeOrder", "Order_Id", "dbo.Order");
            DropForeignKey("dbo.CakeOrder", "Cake_Id", "dbo.Cake");
            DropForeignKey("dbo.Message", "User_Id", "dbo.User");
            DropForeignKey("dbo.Roles", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Roles", "UserId", "dbo.User");
            DropForeignKey("dbo.User", "District_Id", "dbo.District");
            DropForeignKey("dbo.User", "City_Id", "dbo.City");
            DropForeignKey("dbo.District", "City_Id", "dbo.City");
            DropForeignKey("dbo.Cake", "Category_Id", "dbo.Category");
            DropForeignKey("dbo.Category", "Image_Id", "dbo.Image");
            DropForeignKey("dbo.Image", "Cake_Id", "dbo.Cake");
            DropIndex("dbo.Image", new[] { "Reference_Id" });
            DropIndex("dbo.Order", new[] { "User_Id" });
            DropIndex("dbo.Order", new[] { "Delivery_Id" });
            DropIndex("dbo.Order", new[] { "Category_Id" });
            DropIndex("dbo.CakeOrder", new[] { "Order_Id" });
            DropIndex("dbo.CakeOrder", new[] { "Cake_Id" });
            DropIndex("dbo.Message", new[] { "User_Id" });
            DropIndex("dbo.Roles", new[] { "RoleId" });
            DropIndex("dbo.Roles", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "District_Id" });
            DropIndex("dbo.User", new[] { "City_Id" });
            DropIndex("dbo.District", new[] { "City_Id" });
            DropIndex("dbo.Cake", new[] { "Category_Id" });
            DropIndex("dbo.Category", new[] { "Image_Id" });
            DropIndex("dbo.Image", new[] { "Cake_Id" });
            DropTable("dbo.Roles");
            DropTable("dbo.Reference");
            DropTable("dbo.Delivery");
            DropTable("dbo.CakeOrder");
            DropTable("dbo.Order");
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.Message");
            DropTable("dbo.Membership");
            DropTable("dbo.District");
            DropTable("dbo.City");
            DropTable("dbo.Category");
            DropTable("dbo.Image");
            DropTable("dbo.Cake");
        }
    }
}
