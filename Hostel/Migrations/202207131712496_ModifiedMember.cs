namespace Hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedMember : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Members", new[] { "RoomId" });
            AlterColumn("dbo.Members", "RoomId", c => c.Int());
            CreateIndex("dbo.Members", "RoomId");
            AddForeignKey("dbo.Members", "RoomId", "dbo.Rooms", "RoomId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Members", new[] { "RoomId" });
            AlterColumn("dbo.Members", "RoomId", c => c.Int(nullable: false));
            CreateIndex("dbo.Members", "RoomId");
            AddForeignKey("dbo.Members", "RoomId", "dbo.Rooms", "RoomId", cascadeDelete: true);
        }
    }
}
