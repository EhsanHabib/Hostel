namespace Hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessCharges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessCharges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        Charges = c.Int(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessCharges", "MemberId", "dbo.Members");
            DropIndex("dbo.MessCharges", new[] { "MemberId" });
            DropTable("dbo.MessCharges");
        }
    }
}
