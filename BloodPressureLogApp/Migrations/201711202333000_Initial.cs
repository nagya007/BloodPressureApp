namespace BloodPressureLogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        IsAm = c.Boolean(nullable: false),
                        Sys = c.Int(nullable: false),
                        Dia = c.Int(nullable: false),
                        Pulse = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Name = c.String(),
                        Password = c.String(),
                        Adress = c.String(),
                        PhoneNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "UserId", "dbo.Users");
            DropIndex("dbo.Entries", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Entries");
        }
    }
}
